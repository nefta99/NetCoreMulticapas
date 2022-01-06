using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utils
{
    public static class Constants
    {
        public static class Configuration
        {
            public const string PIINSDbConnection = "PIINSDbConnection";
            public const string PIINSCorsPolicy = "PIINSCorsPolicy";
            public const string PIINSCorsDomain = "PIINSCorsDomain";
            public const string ClaimEnrollmentAttributte = "ClaimEnrollmentAttributte";
            public const string PeriodTerm = "PeriodTerm";
            public const string UserEnrollment = "UserEnrollment";
            public const string UFSS = "UFSS";
            public const string FederationFlow = "FederationFlow";
            public const string UrlPiinsDomain = "UrlPiinsDomain";
            public const string SendGridApiKey = "SendGridApiKey";
            public const string SendGridEmail = "SendGridEmail";
            public const string SendGridName = "SendGridName";
            public const string SendGridUrl = "SendGridUrl";
            public const string SendGridTemplateId = "SendGridTemplateId";
            public const string SendGridContent = "SendGridContent";
            public const string LogoImage = "LogoImage";
            public const string Consultant = "CONSULTOR";
            public const string Student = "ESTUDIANTE";
            public const string Teacher = "DOCENTE";
            public const string Colaborador = "COLABORADOR";
            public const string AdminCampus = "ADMIN_SS_Campus";
            public const string AdminNacional = "ADMIN_SS_Nacional";
            public const string InitialStudentEnrollment = "A";
            public const string InitialTeacherEnrollment = "L";
            public const string PeriodActual = "1";
            public const string PreviousPeriod = "2";
            public const string AllPeriod = "3";
            public const string PreviousPeriodTerm = "PreviousPeriodTerm";
            public const string AllPeriodTerm = "PeriodTerm";
            public const string AzureBlobKey = "AzureBlobKey";
            public const string AzureContainerName = "AzureContainerName";
            public const string Admin = "ADMIN";
            public const string LeaderStudent = "Estudiante Líder";
            public const string CoauthorStudent = "Estudiante Coautor";
            public const string Professor = "Docente";
            public const string StudentMailInitials = "A0";
            public const string ProfessorDomainMail = "@tec.mx";
            public const string StudentTypeMail = "A";
            public const string ProfessorTypeMail = "E";
            public const string Campus = "Campus ";
            public const string SubjectMailContactAutors = "Solicitud de Información de Iniciativa Social";
            public const string SendGridContentAutor = "SendGridContentAutor";
            public const string PeriodDaysToRun = "PeriodDaysToRun";
            public const string MinimumNumberVisits = "MinimumNumberVisits";
            public const string MinimumNumberYears = "MinimumNumberYears";
            public const string ScheduledStatus = "ScheduledStatus";
            public const string SubjectMailPublishInitiative = "Publicación de iniciativa";
            public const string IsUsurperEnabled = "IsUsurperEnabled";
            public const string AllCampus = "ALL";
            public const string DateFilterPeriods = "DateFilterPeriods";
        }

        public static class Common
        {
            public const string ERROR_GENERIC = "Error generico";
            public const string SUCCESS = "Exito";
            public const string UNAUTHORIZED = "Sin autorización";
            public const string NOENROLLMENT = "No Enrollment";
            public const string NOUSERFOUND = "User not found";
            public const string FILENOTFOUND = "File not found";
            public const string NOUSURPERFOUND = "Usurper user not found";
            public const string PORTALINVALID = "Portal invalido";
        }

        public static class UserErrorMessage
        {
            public const string NO_ENOUGH_PRIVILEGES = "No tiene permisos suficientes para realizar esta acción";
            public const string CAMPUS_SERVICE_NOT_RESPOND = "El servicio de campus no responde";
            public const string ERROR_ALL_CAMPUS_SERVICE_BY_FILTER = "Error al obtener todos los campus por filtro";
            public const string ERROR_GET_ALL_CONTACT = "Error al obtener el directorio de contacto";
            public const string ERROR_GET_PERIODS = "Error al obtener los periodos para el filtro";
            public const string ERROR_GET_COAUTHORS = "Error al obtener los coautores";
            public const string ERROR_CONTACT_AUTHOR = "Ha ocurrido un error, no se envió la notificación, intentar de nuevo";
            public const string ERROR_GET_EXPERIENCE_TYPE = "Error al obtener los tipos de experiencias";
            public const string ERROR_SAVE_INITIATIVE_DOCUMENT = "Error al guardar documento";
            public const string ERROR_DOWNLOAD_DOCUMENT_INITIATIVE = "Error al descargar documento de una iniciativa";
            public const string ERROR_DOWNLOAD_ALL_DOCUMENT_INITIATIVE = "Error al descargar todos los documentos de una iniciativa";
            public const string ERROR_GET_DOCUMENT_INITIATIVE = "Error al obtener documento de una iniciativa";
            public const string ERROR_SAVE_INITIATIVE = "Error al guardar una iniciativa";
            public const string ERROR_UDATE_CESSIONRIGHTS = "Error al actualizar la carta de cesión de derechos";
            public const string ERROR_GET_INITIATIVE_USER = "Error al obtener iniciativa de un usuario";
            public const string ERROR_UPDATE_INITIATIVE = "Ha ocurrido un error al editar una iniciativa";
            public const string ERROR_PUBLISH_INITIATIVE = "Ha ocurrido un error, iniciativa no publicada con éxito";
            public const string ERROR_INITIATIVE_DESCRIPTION = "Error al obtener la descripción de una iniciativa";
            public const string ERROR_INITIATIVE_TO_EDITION = "Error al obtener una iniciativa para su edición";
            public const string ERROR_FILTER_INITIATIVE = "Error al filtrar iniciativas";
            public const string ERROR_DOWNLOAD_REPORT_INITIATIVE_FILTERED = "Error al descargar el reporte de iniciativas filtradas";
            public const string ERROR_UPDATE_STATE_INITIATIVE = "Ha ocurrido un error al {0} la iniciativa, intentar de nuevo";
            public const string ERROR_INITIATIVE_TYPE = "Error al obtener los tipos de iniciativas";
            public const string ERROR_ALL_ODS = "Error al obtener todos los ODS";
            public const string ERROR_ALL_ODS_SUBCATEGORIES = "Error al obtener todas las ODS SubCategories";
            public const string ERROR_ALL_OFS = "Error al obtener todos los OFS";
            public const string ERROR_ALL_OFS_SUBCATEGORIES = "Error al obtener todos los OFS SubCategories";
            public const string ERROR_REGIONS = "Error al obtener todas las regiones";
            public const string ERROR_STAGES = "Error al obtener las etapas";
            public const string ERROR_TARGET_POPULATIONS = "Error al obtener las poblaciones atendidas";
            public const string ERROR_SAVE_DOWNLOAD_LOG = "Error al guardar la descarga del documento";
            public const string ENROLLMENT_INVALID = "Matricula invalida";
            public const string ERROR_GET_INFORMATION = "Error al recuperar información";
            public const string ERROR_DELETE_INITIATIVE_DOCUMENT = "Ha ocurrido un error, no se eliminó el archivo, intentar de nuevo";
        }

        public static class InitiativeType
        {
            public const string InProcess = "InProcess";
            public const string Published = "Published";
            public const string NoPublished = "NoPublished";
        }

        public static class Report
        {
            public const string ReportSheetNameInitiatives = "Iniciativas";
            public const string ReportContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            public const string ReportInitiativesFilename = "Iniciativas_{0}";

            public static readonly string[] HeaderReport = {
                "Periodo",
                "CRN",
                "Tipo de experiencia",
                "Fecha de registro",
                "Region",
                "Campus",
                "Tipo de iniciativa",
                "Nombre de iniciativa",
                "Osf",
                "Subcategoria Osf",
                "Población",
                "Conocimientos necesarios",
                "Contexto",
                "Ods",
                "Subcategoria Ods",
                "Descripción",
                "Palabras claves",
                "Descripción de la solución",
                "Evolución a",
                "Carta de derechos cedidos",
                "Resultado obtenido",
                "Provee solución",
                "Ayuda Osf",
                "Continuidad de servicios",
                "Transforma trabajos",
                "Beneficiarios",
                "Recomendaciones",
                "Profesor asignado",
                "Administrador asignado",
                "Líder de la iniciativa",
                "Coautores de la iniciativa",
                "Nombre líder",
                "Nombre de coautores",
                "Etapa",
                "Estatus activa",
                "Estatus publicación",
                "Indicador importación",
                "Carga de portada",
                "Carga de documentos"
            };
        }
    }
}
