using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Root.Reports;
using System.Drawing;
using System.Data;

namespace ITCR.UDSystem.Negocios.ClasesNegocios
{
    public class cReporte
    {
        #region Declaraciones de miembros de clase
        private double _dRx = 0, _dRy = 0, _dMaxRx = 0, _dMaxRy = 0;
        private int _iSize = 0, _iRedTitulo, _iGreenTitulo, _iBlueTitulo, _iRedSub, _iGreenSub, _iBlueSub;
        private string _sFont;
        private DateTime _sfechainicio, _sfechafin;
        #endregion

        #region Orden de solicitudes
        /*
         * drRow[0] = ID_SOLICITUD
         * drRow[1] = FKY_INSTALACION
         * drRow[2] = FEC_INICIO
         * drRow[3] = FEC_FIN
         * drRow[4] = FEC_SOLICITUD
         * drRow[5] = HRA_INICIO
         * drRow[6] = HRA_FIN
         * drRow[7] = NOM_ENCARGADO
         * drRow[8] = NOM_INSTITUCION
         * drRow[9] = COD_IDENTIFICACION
         * drRow[10] = FKY_TIPOSOLICITANTE
         * drRow[11] = TXT_OBSERVACIONES
         * drRow[12] = DSC_RAZONUSO
         * drRow[13] = COD_TIPOSOLICITUD
         * drRow[14] = TXT_CORREO
         * drRow[15] = COD_ATENDIDO
         * drRow[16] = TXT_USUARIOS
         * drRow[17] = CAN_USUARIOSH
         * drRow[18] = CAN_USUARIOSM
         * drRow[19] = NOM_INSTALACION
         * drRow[20] = DSC_TPSOLTNTE
         */
        #endregion

        /// <summary>
        /// Genera un objeto del tipo cReporte
        /// </summary>
        /// <param name="p_default">Indica si se desean los valores predeterminados</param>
        /// <param name="p_fechainicio">Fecha inicio del reporte</param>
        /// <param name="p_fechafin">Fecha fin del reporte</param>
        public cReporte(Boolean p_default, String p_fechainicio, String p_fechafin)
        {
            if (p_default)
                SetDefault();

            _sfechainicio = DateTime.Parse(p_fechainicio);
            _sfechafin = DateTime.Parse(p_fechafin);
        }

        /// <summary>
        /// Crea un reporte
        /// </summary>
        /// <returns></returns>
        public Report Generar()
        {
            // Inicialización de los componentes del documento
            Report rReporte = new Report(new PdfFormatter());
            FontDef fd = new FontDef(rReporte, _sFont);
            FontProp fp = new FontProp(fd, _iSize);
            Page pPagina = new Page(rReporte);
            cUDGDFSOLICITUDNegocios sSolicitudes = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
            DataTable dtSolicitudes;
            String[] sUsuarios;
            int iContadorUsuarios = 1;

            // Obtiene las solicitudes aprobadas dentro del rango de fechas
            dtSolicitudes = sSolicitudes.SeleccionarAprobadas(_sfechainicio, _sfechafin);

            // Imprime el documento
            // Encabezado del documento
            InsertarTitulo("Reporte de reservaciones", fp, pPagina, rReporte);
            InsertarTitulo(_sfechainicio.ToShortDateString() + " - " + _sfechafin.ToShortDateString(), fp, pPagina, rReporte);
            InsertarLinea("", fp, pPagina, rReporte);

            // Resumen del documento
            InsertarSubtitulo("Resumen de reservaciones", fp, pPagina, rReporte);
            foreach (Instalacion insLocal in GenerarResumen(dtSolicitudes))
            {
                InsertarLinea("Reservaciones para " + insLocal.sInstalacion + ": " + insLocal.iContador + ".", fp, pPagina, rReporte);
            }
            InsertarLinea("", fp, pPagina, rReporte);
            InsertarDivisor(fp, pPagina, rReporte);
            InsertarLinea("", fp, pPagina, rReporte);

            // Imprime cada solicitud
            InsertarSubtitulo("Solicitudes aprobadas dentro del rango de fechas", fp, pPagina, rReporte);
            InsertarLinea("", fp, pPagina, rReporte);

            foreach (DataRow drRow in dtSolicitudes.Rows)
            {
                InsertarLinea("Identificacion de solicitud: " + drRow[0].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Fecha inicio: " + DateTime.Parse(drRow[2].ToString()).ToShortDateString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Fecha fin: " + DateTime.Parse(drRow[3].ToString()).ToShortDateString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Fecha de la solicitud: " + DateTime.Parse(drRow[4].ToString()).ToShortDateString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Hora inicio: " + drRow[5].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Hora fin: " + drRow[6].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Nombre de encargado: " + drRow[7].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Nombre de institucion/grupo: " + drRow[8].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Identificacion encargado: " + drRow[9].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Tipo de Solicitante: " + drRow[20].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Observaciones: " + drRow[11].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Razon de uso: " + drRow[12].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Correo solicitante: " + drRow[14].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Usuarios:", fp, pPagina, rReporte);
                sUsuarios = drRow[16].ToString().Split(',');
                foreach (String sLocal in sUsuarios)
                {
                    InsertarLinea(iContadorUsuarios + ". " + sLocal, fp, pPagina, rReporte);
                    iContadorUsuarios++;
                }
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Cantidad de usuarios hombres: " + drRow[17].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarLinea("Cantidad de usuarios mujeres: " + drRow[18].ToString(), fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
                InsertarDivisor(fp, pPagina, rReporte);
                InsertarLinea("", fp, pPagina, rReporte);
            }

            // retorna el documento para poder ser presentado al usuario
            return rReporte;
        }

        /// <summary>
        /// Genera una lista de las instalaciones, con la cantidad de reservaciones por instalacion
        /// </summary>
        /// <param name="dtSolicitudes">Solicitudes</param>
        /// <returns>List of Instalacion Object</returns>
        private List<Instalacion> GenerarResumen(DataTable dtSolicitudes)
        {
            List<Instalacion> liInstalaciones = new List<Instalacion>();
            foreach (DataRow drRow in dtSolicitudes.Rows)
            {
                if (Existe(liInstalaciones, drRow[19].ToString()))
                    ObtenerInstalacion(liInstalaciones, drRow[19].ToString()).Añadir();// Añade al contador
                else
                {
                    Instalacion insTemporal = new Instalacion(drRow[19].ToString());
                    liInstalaciones.Add(insTemporal);
                }
            }
            return liInstalaciones;
        }

        /// <summary>
        /// Obtiene una instalacion especifica de la lista
        /// </summary>
        /// <param name="p_Instalaciones">Lista de instalaciones</param>
        /// <param name="p_Instalacion">Nombre de la instalacion a buscar</param>
        /// <returns>Instalacion Object</returns>
        private Instalacion ObtenerInstalacion(List<Instalacion> p_Instalaciones, String p_Instalacion)
        {
            Instalacion toReturn = new Instalacion();
            foreach (Instalacion insLocal in p_Instalaciones)
            {
                if (insLocal.sInstalacion.CompareTo(p_Instalacion) == 0)
                {
                    toReturn = insLocal;
                    break;
                }
            }
            return toReturn;
        }

        /// <summary>
        /// Indica si existe una instalacion en la lista
        /// </summary>
        /// <param name="p_Instalaciones">Lista de instalaciones</param>
        /// <param name="p_Instalacion">instalacion a buscar</param>
        /// <returns>True si existe</returns>
        private bool Existe(List<Instalacion> p_Instalaciones, String p_Instalacion)
        {
            foreach (Instalacion insLocal in p_Instalaciones)
            {
                if (insLocal.sInstalacion.CompareTo(p_Instalacion) == 0)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Añade una nueva linea en la posicion donde se encuentra posicionado el cursor
        /// </summary>
        /// <param name="p_Texto">Linea a escribir</param>
        /// <param name="p_Font">Fuente del texto</param>
        /// <param name="p_Pagina">Pagina en la que se desea escribir</param>
        /// <param name="p_Reporte">Archivo sobre el que se esta escribiendo</param>
        /// <returns>Pagina actual</returns>
        private Page InsertarLinea(String p_Texto, FontProp p_Font, Page p_Pagina, Report p_Reporte)
        {
            if (_dRy >= _dMaxRy)
            {
                p_Pagina = new Page(p_Reporte);
                _dRy = 60;
            }

            if (p_Texto.Length <= 80)
            {
                p_Pagina.Add(_dRx, _dRy, new RepString(p_Font, p_Texto));
                _dRy += p_Font.rLineFeedMM;
            }
            else
            {
                p_Pagina.Add(_dRx, _dRy, new RepString(p_Font, p_Texto.Substring(0, 80)));
                _dRy += p_Font.rLineFeedMM;
                InsertarLinea(p_Texto.Substring(80, p_Texto.Length - 80), p_Font, p_Pagina, p_Reporte);
            }
            return p_Pagina;
        }

        /// <summary>
        /// Inserta un titulo en la pagina pasada como parámetro en la posicion del cursor
        /// </summary>
        /// <param name="p_Subtitulo">Subtitulo a insertar</param>
        /// <param name="p_Font">FontProp de el reporte</param>
        /// <param name="p_Pagina">Pagina sobre la que se desea escribir el subtitulo</param>
        /// <param name="p_Reporte">Documento actual</param>
        /// <returns>Pagina actual</returns>
        private Page InsertarTitulo(String p_Titulo, FontProp p_Font, Page p_Pagina, Report p_Reporte)
        {
            if (_dRy >= _dMaxRy)
            {
                p_Pagina = new Page(p_Reporte);
                _dRy = 60;
            }

            // Color: #1240AB.FromArgb(18, 64, 171)
            p_Font.color = Color.FromArgb(_iRedTitulo, _iGreenTitulo, _iBlueTitulo);
            p_Font.bItalic = true;
            p_Font.bBold = true;
            p_Font.rSizePoint += 10;
            p_Pagina.AddCB(_dRy, new RepString(p_Font, p_Titulo));
            _dRy += p_Font.rLineFeed;

            // Restores to Default
            p_Font.rSizePoint -= 10;
            p_Font.color = Color.Black;
            p_Font.bItalic = false;
            p_Font.bBold = false;

            return p_Pagina;
        }

        /// <summary>
        /// Inserta un subtitulo en la pagina pasada como parámetro en la posicion del cursor
        /// </summary>
        /// <param name="p_Subtitulo">Subtitulo a insertar</param>
        /// <param name="p_Font">FontProp de el reporte</param>
        /// <param name="p_Pagina">Pagina sobre la que se desea escribir el subtitulo</param>
        /// <param name="p_Reporte">Documento actual</param>
        /// <returns>Pagina actual</returns>
        private Page InsertarSubtitulo(String p_Subtitulo, FontProp p_Font, Page p_Pagina, Report p_Reporte)
        {
            if (_dRy >= _dMaxRy)
            {
                p_Pagina = new Page(p_Reporte);
                _dRy = 60;
            }

            // Color: #4671D5.FromArgb(70, 113, 213);
            p_Font.color = Color.FromArgb(_iRedSub, _iGreenSub, _iBlueSub);
            p_Font.bUnderline = true;
            p_Font.bItalic = true;
            p_Font.bBold = true;
            p_Font.rSizePoint += 5;
            p_Pagina.Add(_dRx, _dRy, new RepString(p_Font, p_Subtitulo));
            _dRy += p_Font.rLineFeed;

            // Restores to Default
            p_Font.rSizePoint -= 5;
            p_Font.color = Color.Black;
            p_Font.bUnderline = false;
            p_Font.bItalic = false;
            p_Font.bBold = false;

            return p_Pagina;
        }

        /// <summary>
        /// Inserta una linea divisora en la posicion del cursor
        /// </summary>
        /// <param name="p_Font">FontProp de el reporte</param>
        /// <param name="p_Pagina">Pagina sobre la que se desea escribir el subtitulo</param>
        /// <param name="p_Reporte">Documento actual</param>
        /// <returns>Pagina actual</returns>
        private Page InsertarDivisor(FontProp p_Font, Page p_Pagina, Report p_Reporte)
        {
            String sLinea = " ";

            for (int iContador = 0; iContador < 160; iContador++)
                sLinea += " ";

            if (_dRy >= _dMaxRy)
            {
                p_Pagina = new Page(p_Reporte);
                _dRy = 60;
            }

            p_Font.bUnderline = true;
            p_Pagina.Add(_dRx, _dRy, new RepString(p_Font, sLinea));
            _dRy += p_Font.rLineFeedMM;
            p_Font.bUnderline = false;

            return p_Pagina;
        }

        /// <summary>
        /// Inicializa todos los valores con el valor default usado
        /// </summary>
        private void SetDefault()
        {
            _sFont = "Helvetica";
            _iSize = 8;
            _dRy = 60;
            _dRx = 50;
            _dMaxRy = 782;
            _dMaxRx = 40;
            _iRedTitulo = 18;
            _iGreenTitulo = 64;
            _iBlueTitulo = 171;
            _iRedSub = 70;
            _iGreenSub = 113;
            _iBlueSub = 213;
        }

        #region Declaraciones de propiedades de la clase
        /// <summary>
        /// Inicio en el eje X del texto
        /// </summary>
        public double dRX
        {
            get
            {
                return _dRx;
            }
            set
            {
                Double dTemporal;
                if (Double.TryParse(value.ToString(), out dTemporal))
                    _dRx = (Double)value;
                else
                    throw new ArgumentOutOfRangeException("dRX", "dRX is a Double");
            }
        }

        /// <summary>
        /// Inicio en el eje Y del texto
        /// </summary>
        public double dRY
        {
            get
            {
                return _dRy;
            }
            set
            {
                Double dTemporal;
                if (Double.TryParse(value.ToString(), out dTemporal))
                    _dRy = (Double)value;
                else
                    throw new ArgumentOutOfRangeException("dRY", "dRY is a Double");
            }
        }

        /// <summary>
        /// Rango Máximo del incremento en Rx
        /// </summary>
        public double dMAXRX
        {
            get
            {
                return _dMaxRx;
            }
            set
            {
                Double dTemporal;
                if (Double.TryParse(value.ToString(), out dTemporal))
                    _dMaxRx = (Double)value;
                else
                    throw new ArgumentOutOfRangeException("dMAXRX", "dMAXRX is a Double");
            }
        }

        /// <summary>
        /// Rango Máximo del incremento en Ry
        /// </summary>
        public double dMAXRY
        {
            get
            {
                return _dMaxRy;
            }
            set
            {
                Double dTemporal;
                if (Double.TryParse(value.ToString(), out dTemporal))
                    _dMaxRy = (Double)value;
                else
                    throw new ArgumentOutOfRangeException("dMAXRY", "dMAXRY is a Double");
            }
        }

        /// <summary>
        /// Tamaño de la letra del documento
        /// </summary>
        public int iSIZE
        {
            get
            {
                return _iSize;
            }
            set
            {
                int iTemporal;
                if (int.TryParse(value.ToString(), out iTemporal))
                    _iSize = (int)value;
                else
                    throw new ArgumentOutOfRangeException("iSIZE", "iSIZE is an Integer");
            }
        }

        /// <summary>
        /// Tipo de Letra del documento
        /// Los tipos validos son: courier,helvetica,times-roman,symbol,zapfdingbats
        /// </summary>
        public String sFONT
        {
            get
            {
                return _sFont;
            }
            set
            {
                if ("courier,helvetica,times-roman,symbol,zapfdingbats".Contains(value.ToString().ToLower()))
                    _sFont = value.ToString();
                else
                    throw new ArgumentException("sFONT", "sFONT isn't one of the valid fonts");
            }
        }

        /// <summary>
        /// Color rojo de los titulos
        /// Basado en el RGB
        /// </summary>
        public int iREDTITULO
        {
            get
            {
                return _iRedTitulo;
            }
            set
            {
                int iTemporal;
                if (int.TryParse(value.ToString(), out iTemporal))
                    _iRedTitulo = (int)value;
                else
                    throw new ArgumentOutOfRangeException("iREDTITULO", "iREDTITULO is an Integer");
            }
        }

        /// <summary>
        /// Color Verde de los titulos
        /// Basado en el RGB
        /// </summary>
        public int iGREENTITULO
        {
            get
            {
                return _iGreenTitulo;
            }
            set
            {
                int iTemporal;
                if (int.TryParse(value.ToString(), out iTemporal))
                    _iGreenTitulo = (int)value;
                else
                    throw new ArgumentOutOfRangeException("iGREENTITULO", "iGREENTITULO is an Integer");
            }
        }

        /// <summary>
        /// Color azul de los titulos
        /// Basado en el RGB
        /// </summary>
        public int iBLUETITULO
        {
            get
            {
                return _iBlueTitulo;
            }
            set
            {
                int iTemporal;
                if (int.TryParse(value.ToString(), out iTemporal))
                    _iBlueTitulo = (int)value;
                else
                    throw new ArgumentOutOfRangeException("iBLUETITULO", "iBLUETITULO is an Integer");
            }
        }

        /// <summary>
        /// Color rojo de lo subtitutlos
        /// Basado en el RGB
        /// </summary>
        public int iREDSUB
        {
            get
            {
                return _iRedSub;
            }
            set
            {
                int iTemporal;
                if (int.TryParse(value.ToString(), out iTemporal))
                    _iRedSub = (int)value;
                else
                    throw new ArgumentOutOfRangeException("iREDSUB", "iREDSUB is an Integer");
            }
        }

        /// <summary>
        /// Color verde de los subtitulos
        /// Basado en el RGB
        /// </summary>
        public int iGREENSUB
        {
            get
            {
                return _iGreenSub;
            }
            set
            {
                int iTemporal;
                if (int.TryParse(value.ToString(), out iTemporal))
                    _iGreenSub = (int)value;
                else
                    throw new ArgumentOutOfRangeException("iGREENSUB", "iGREENSUB is an Integer");
            }
        }

        /// <summary>
        /// Color Azul de los subtitulos
        /// Basado en el RGB
        /// </summary>
        public int iBLUESUB
        {
            get
            {
                return _iBlueSub;
            }
            set
            {
                int iTemporal;
                if (int.TryParse(value.ToString(), out iTemporal))
                    _iBlueSub = (int)value;
                else
                    throw new ArgumentOutOfRangeException("iBLUESUB", "iBLUESUB is an Integer");
            }
        }
        #endregion

        #region Declaraciones de structs
        /// <summary>
        /// Struct para el control de cantidad de instalaciones
        /// </summary>
        private struct Instalacion
        {
            public String sInstalacion;
            public int iContador;

            /// <summary>
            /// Genera un struct del tipo Instalacion
            /// </summary>
            /// <param name="p_instalacion">Nombre de la instalacion</param>
            public Instalacion(String p_instalacion)
            {
                sInstalacion = p_instalacion;
                iContador = 1;
            }

            /// <summary>
            /// Añade una instalacion al contador
            /// </summary>
            public void Añadir()
            {
                iContador += 1;
            }
        }
        #endregion
    }
}
