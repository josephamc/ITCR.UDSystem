#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFEVENTO'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: viernes 18 de enero de 2013, 11:31:46 a.m.
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
    /// Propósito: Clase de acceso a datos derivada para tabla 'UDGDFEVENTO'.
    /// </summary>
    public class cUDGDFEVENTODatos : cUDGDFEVENTOBase
    {


        /// <summary>
        /// Propósito: Constructor de la clase.
        /// </summary>
        public cUDGDFEVENTODatos()
            : base()
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
        ///		 <LI>DSC_EVENTO</LI>
        ///		 <LI>NOM_EVENTO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>ID_EVENTO</LI>
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
        ///		 <LI>ID_EVENTO</LI>
        ///		 <LI>DSC_EVENTO</LI>
        ///		 <LI>NOM_EVENTO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
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
        ///		 <LI>ID_EVENTO</LI>
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
        ///		 <LI>ID_EVENTO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        ///		 <LI>ID_EVENTO</LI>
        ///		 <LI>DSC_EVENTO</LI>
        ///		 <LI>NOM_EVENTO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
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
        ///		 <LI>ID_EVENTO</LI>
        ///		 <LI>DSC_EVENTO</LI>
        ///		 <LI>NOM_EVENTO</LI>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>COD_LUNES</LI>
        ///		 <LI>COD_MARTES</LI>
        ///		 <LI>COD_MIERCOLES</LI>
        ///		 <LI>COD_JUEVES</LI>
        ///		 <LI>COD_VIERNES</LI>
        ///		 <LI>COD_SABADO</LI>
        ///		 <LI>COD_DOMINGO</LI>
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
