#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFSOLICITUD'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: sábado, 22 de diciembre de 2012, 09:53:59 a.m.
// Dado que esta clase implementa IDispose, las clases derivadas no deben hacerlo.
///////////////////////////////////////////////////////////////////////////
#endregion


using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using ITCR.UDSystem.Base;

namespace ITCR.UDSystem.Datos
{
	/// <summary>
	/// Propósito: Clase de acceso a datos derivada para tabla 'UDGDFSOLICITUD'.
	/// </summary>
	public class cUDGDFSOLICITUDDatos : cUDGDFSOLICITUDBase
	{


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFSOLICITUDDatos() : base()
		{
			// Agregar código aquí.
		}


		/// <summary>
		/// Propósito: Método Insertar. Este método inserta una fila nueva en la base de datos.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
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
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_SOLICITUD</LI>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Insertar()
		{
			return base.Insertar();
		}


		/// <summary>
		/// Propósito: Método Update. Actualiza una fila existente en la base de datos.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_SOLICITUD</LI>
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
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Actualizar()
		{
			return base.Actualizar();
		}


		/// <summary>
		/// Propósito: Método Eliminar. Borra una fila en la base de datos, basado en la llave primaria.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Eliminar()
		{
			return base.Eliminar();
		}


		/// <summary>
		/// Propósito: Método SELECT. Este método hace Select de una fila existente en la base de datos, basado en la llave primaria.
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		///		 <LI>ID_SOLICITUD</LI>
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
		///		 <LI>TXT_OBSERVACIONES</LI>
		///		 <LI>DSC_RAZONUSO</LI>
		///		 <LI>COD_TIPOSOLICITUD</LI>
		///		 <LI>TXT_CORREO</LI>
		///		 <LI>COD_ATENDIDO</LI>
		/// </UL>
		/// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
		/// </remarks>
		public override DataTable SeleccionarUno()
		{
			return base.SeleccionarUno();
		}


		/// <summary>
		/// Propósito: Método SeleccionarTodos. Este método va a Hacer un SELECT All de tabla.
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable SeleccionarTodos()
		{
			return base.SeleccionarTodos();
		}


		/// <summary>
		/// Propósito: Método Buscar. Este método va a Hacer un SELECT de tabla.
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_SOLICITUD</LI>
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
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable Buscar()
		{
			//TODO: agregar % para busqueda de campos string (varchar, etc.) con LIKE (el procedimiento ya lo hace), así:
			//if (!base.DescripcionCF.IsNull) {
				//    base.DescripcionCF = "{0}" + base.DescripcionCF + "{0}"; }
			return base.Buscar();
		}
	} //class
} //namespace
