using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Root.Reports;
using System.Drawing;

namespace ITCR.UDSystem.Negocios.ClasesNegocios
{
    public class cReporte
    {
        #region Declaraciones de miembros de clase
        private double _dRx = 0, _dRy = 0, _dMaxRx = 0, _dMaxRy = 0;
        private int _iSize = 0, _iRedTitulo, _iGreenTitulo, _iBlueTitulo, _iRedSub, _iGreenSub, _iBlueSub;
        private string _sFont, _sfechainicio, _sfechafin;
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

            // Imprime el documento
            // Titulo
            InsertarTitulo("Reporte de reservaciones", fp, pPagina, rReporte);
            InsertarTitulo(_sfechainicio + " - " + _sfechafin, fp, pPagina, rReporte);
            

            
            InsertarSubtitulo("Subtitutlo prueba", fp, pPagina, rReporte);
            int j = 0;
            for (; j < 100; j++)
                pPagina = InsertarLinea("Linea " + j, fp, pPagina, rReporte);

            // retorna el documento para poder ser presentado al usuario
            return rReporte;
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
            p_Pagina.Add(_dRx, _dRy, new RepString(p_Font, p_Texto));
            _dRy += p_Font.rLineFeedMM;
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
        /// Inicializa todos los valores con el valor default usado
        /// </summary>
        private void SetDefault()
        {
            _sFont = "Helvetica";
            _iSize = 8;
            _dRy = 60;
            _dRx = 40;
            _dMaxRy = 782;
            _dMaxRx = 40;
            _iRedTitulo = 18;
            _iGreenTitulo = 64;
            _iBlueTitulo = 171;
            _iRedSub = 70;
            _iGreenSub = 113;
            _iRedSub = 213;
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
    }
}
