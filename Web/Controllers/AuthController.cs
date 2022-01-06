using ITfoxtec.Identity.Saml2;
using ITfoxtec.Identity.Saml2.Schemas;
using ITfoxtec.Identity.Saml2.MvcCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Identity;
using Microsoft.Extensions.Options;
using System.Security.Authentication;
using System;
using Eventos;
using Services.Services.Interfaces;

namespace Web.Controllers
{
    [AllowAnonymous]
    [Route("Auth")]
    public class AuthController : Controller
    {
        const string relayStateReturnUrl = "ReturnUrl";
        private readonly Saml2Configuration config;
        private readonly IConfiguracionServices ConfiguracionServices;

        public AuthController(IOptions<Saml2Configuration> configAccessor,IConfiguracionServices ConfiguracionServicess)
        {
            config = configAccessor.Value;
            this.ConfiguracionServices = ConfiguracionServicess ?? throw new ArgumentNullException(nameof(ConfiguracionServicess));
        }


        [Route("Login")]
        public IActionResult Login(string returnUrl = null)
        {

            var binding = new Saml2RedirectBinding();
            binding.SetRelayStateQuery(new Dictionary<string, string> { { relayStateReturnUrl, returnUrl ?? Url.Content("~/") } });

            return binding.Bind(new Saml2AuthnRequest(config)).ToActionResult();
        }

        [Route("AssertionConsumerService")]
        public async Task<IActionResult> AssertionConsumerService()
        {
            try
            {
                var binding = new Saml2PostBinding();
                var saml2AuthnResponse = new Saml2AuthnResponse(config);

                binding.ReadSamlResponse(Request.ToGenericHttpRequest(), saml2AuthnResponse);
                if (saml2AuthnResponse.Status != Saml2StatusCodes.Success)
                {
                    throw new AuthenticationException($"SAML Response status: {saml2AuthnResponse.Status}");
                }
                binding.Unbind(Request.ToGenericHttpRequest(), saml2AuthnResponse);
                await saml2AuthnResponse.CreateSession(HttpContext, claimsTransform: (claimsPrincipal) => ClaimsTransform.Transform(claimsPrincipal));

                var relayStateQuery = binding.GetRelayStateQuery();
                var returnUrl = relayStateQuery.ContainsKey(relayStateReturnUrl) ? relayStateQuery[relayStateReturnUrl] : Url.Content("~/");
                BitacoraEventos.InsertaEvento("Sin nomina", "Authcontroller", "AssertionConsumerService", returnUrl);
                return Redirect(returnUrl);
            }
            catch (Exception ex)
            {
                BitacoraEventos.InsertaEvento("Sin nomina", "Authcontroller", "Logout", "Error: " + (ex.Message == null ? "" : ex.Message) + " - " + (ex.InnerException == null ? "" : ex.InnerException.ToString()) + " - " + (ex.StackTrace == null ? "" : ex.StackTrace.ToString()));
                throw new Exception("error en assertion", ex);
            }
        }

        [HttpPost("Logout")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect(Url.Content("~/"));
            }

            var binding = new Saml2PostBinding();
            var saml2LogoutRequest = await new Saml2LogoutRequest(config, User).DeleteSession(HttpContext);
            return Redirect("~/");
        }

        [HttpGet]
        [Route("GetClaims")]
        public Dictionary<string, string> GetClaims()
        {

            Dictionary<string, string> response = new Dictionary<string, string>();

            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    foreach (var claim in User.Claims)
                    {
                        string key = claim.Type.Split('/')[claim.Type.Split('/').Length - 1];
                        if (!response.ContainsKey(key))
                            response.Add(key, claim.Value);
                        else
                            response[key] = response[key] + "#" + claim.Value;
                    }

                }

            }
            catch (Exception ex)
            {
                BitacoraEventos.InsertaEvento("Sin nomina", "Authcontroller", "GetClaims", "Error: " + (ex.Message == null ? "" : ex.Message) + " - " + (ex.InnerException == null ? "" : ex.InnerException.ToString()) + " - " + (ex.StackTrace == null ? "" : ex.StackTrace.ToString()));
                throw new Exception("error al obtener claims", ex);
            }
            return response;
        }
        [HttpGet]
        [Route("Ejem")]
        public string Testeo()
        {
            var pruebita = this.ConfiguracionServices.GetConfiguracionPorAtributo("A");

            BitacoraEventos.InsertaEvento("Sin nomina", "Authcontroller", "AssertionConsumerService", "ya entre");
            return "Hola";
        }
    }

}