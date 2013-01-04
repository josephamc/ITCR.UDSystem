using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ITCR.UDSystem.Negocios.ClasesNegocios
{
    public class cSolicitud
    {
        private int _id_Solicitud;

        /// <summary>
        /// Acepta una solicitud realizada por un usuario
        /// </summary>
        public int AceptarSolicitud()
        {
            int iResultado = 1000;
            cUDGDFSOLICITUDNegocios cSolicitud = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
            cUDGDFAPROBACIONNegocios cAprobacion = new cUDGDFAPROBACIONNegocios(0, "", 0, "");
            cUDGDFRESERVACIONNegocios cReservacion = new cUDGDFRESERVACIONNegocios(0, "", 0, "");
            cUDGDFNTIFICACIONNegocios cNotificacion = new cUDGDFNTIFICACIONNegocios(0, "", 0, "");
            String sNotificacionMessage;
            
            DataRow drSolicitud = cSolicitud.BuscarConId(_id_Solicitud).Rows[0];
            
            cNotificacion.ID_NOTIFICACION = 1;
            try
            {
                sNotificacionMessage = cNotificacion.SeleccionarUno().Rows[0][1].ToString();
            }catch
            {
                sNotificacionMessage = "Su solicitud ha sido procesada. Para más informacion del resultado comuniquese con la unidad de deportes del Instituto Tecnológico de Costa Rica.";       
            }

        ///      <LI>ID_SOLICITUD</LI>
		///		 <LI>FKY_INSTALACION</LI>
		///		 <LI>FEC_INICIO</LI>
		///		 <LI>FEC_FIN</LI>
		///		 <LI>FEC_SOLICITUD</LI>
		///		 <LI>HRA_INICIO</LI>
		///		 <LI>HRA_FIN</LI>
		///		 <LI>NOM_ENCARGADO</LI>
		///		 <LI>NOM_INSTITUCION</LI>
		///		 <LI>COD_IDENTIFICACION</LI>
		///		 <LI>CAN_USUARIOS</LI>
		///		 <LI>FKY_TIPOSOLICITANTE</LI>
		///		 <LI>TXT_OBSERVACIONES. May be SqlString.Null</LI>
		///		 <LI>DSC_RAZONUSO</LI>
		///		 <LI>COD_TIPOSOLICITUD</LI>
		///		 <LI>TXT_CORREO</LI>
		///		 <LI>COD_ATENDIDO</LI>
		///		 <LI>TXT_USUARIOS</LI>

            iResultado = cReservacion.ConsultarDisponibilidad(DateTime.Parse(drSolicitud[2].ToString()), DateTime.Parse(drSolicitud[3].ToString()), DateTime.Parse(drSolicitud[5].ToString()), DateTime.Parse(drSolicitud[6].ToString()), int.Parse(drSolicitud[0].ToString()));
            
            if (iResultado == 1)
            {
                // Realiza la reservacion para la solicitud especificada
                cReservacion.FEC_FECHAFIN = (DateTime)drSolicitud[2];
                cReservacion.FEC_FECHAINICIO = (DateTime)drSolicitud[1];
                cReservacion.HRA_HORAINICIO = DateTime.Parse(drSolicitud[4].ToString());
                cReservacion.HRA_HORAFIN = DateTime.Parse(drSolicitud[5].ToString());
                cReservacion.Insertar();

                // Ingresa la solicitud como aceptada
                cAprobacion.FKY_RESEREVACION = cReservacion.ID_RESERVACION;
                cAprobacion.FKY_SOLICITUD = int.Parse(drSolicitud[0].ToString());
                cAprobacion.Insertar();

                // Actualiza la solicitud estableciendola como atendida
                cSolicitud.ActualizarAtendidoConID(int.Parse(drSolicitud[0].ToString()));

                // Envia un correo al usuario
                this.EnviarCorreo(drSolicitud[13].ToString(), drSolicitud[6].ToString(), sNotificacionMessage);

                return 1;
            }

            else
                return -1;
        }

        /// <summary>
        /// Rechaza una solicitud realizada por un usuario
        /// </summary>
        public void RechazarSolicitud()
        {
            cUDGDFSOLICITUDNegocios cSolicitud = new cUDGDFSOLICITUDNegocios(0, "", 0, "");
            cUDGDFNTIFICACIONNegocios cNotificacion = new cUDGDFNTIFICACIONNegocios(0, "", 0, "");
            String sNotificacionMessage;

            DataRow drSolicitud = cSolicitud.BuscarConId(_id_Solicitud).Rows[0];
            cNotificacion.ID_NOTIFICACION = 2;
            try
            {
                sNotificacionMessage = cNotificacion.SeleccionarUno().Rows[0][1].ToString();
            }
            catch
            {
                sNotificacionMessage = "Su solicitud ha sido procesada. Para más informacion del resultado comuniquese con la unidad de deportes del Instituto Tecnológico de Costa Rica.";
            }

            // Envia un correo al usuario
            this.EnviarCorreo(drSolicitud[13].ToString(), drSolicitud[6].ToString(), sNotificacionMessage);
        }

        /// <summary>
        /// Envia un correo a un usuario especifico
        /// </summary>
        /// <param name="p_Email">Direccion electronico a donde enviar el email</param>
        /// <param name="p_Usuario">Nombre del usuario donde se desea enviar el email</param>
        private void EnviarCorreo(String p_Email, String p_Usuario, String p_notificacion)
        {
            // Envia un correo mediante el web service del tec
        }

        public int ID_SOLICITUD
        {
            get
            {
                return _id_Solicitud;
            }
            set
            {
                _id_Solicitud = value;
            }
        }
    }//class
}//namespace
