#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Empresa:  Instituto Tecnológico de Costa Rica
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
//using Microsoft.SqlServer.Types;  //usarlo cuando hay tipos Geometry, Geography, HierarchiId. Está en C:\Program Files\Microsoft SQL Server\100\SDK\Assemblies\Microsoft.SqlServer.Types.dll

namespace ITCR.UDSystem.Base
{
    /// <summary>
    /// Propósito: Clase de acceso a datos para tabla 'UDGDFEVENTO'.
    /// </summary>
    public class cUDGDFEVENTOBase : cBDInteraccionBase
    {
        #region Declaraciones de miembros de la clase
        private SqlBoolean _cOD_LUNES, _cOD_MARTES, _cOD_MIERCOLES, _cOD_JUEVES, _cOD_VIERNES, _cOD_SABADO, _cOD_DOMINGO;
        private SqlInt32 _iD_EVENTO, _fKY_CALENDARIO, _fKY_CALENDARIOOld, _fKY_RESERVACION, _fKY_RESERVACIONOld;
        private SqlString _dSC_EVENTO, _nOM_EVENTO;
        #endregion


        /// <summary>
        /// Propósito: Constructor de la clase.
        /// </summary>
        public cUDGDFEVENTOBase()
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
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_Insertar]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_EVENTO", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_EVENTO", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_CALENDARIO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_CALENDARIO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_RESERVACION));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_LUNES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_LUNES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_MARTES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_MARTES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_MIERCOLES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_MIERCOLES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_JUEVES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_JUEVES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_VIERNES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_VIERNES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_SABADO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_SABADO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_DOMINGO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_DOMINGO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_EVENTO", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _iD_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _iD_EVENTO = Int32.Parse(cmdAEjecutar.Parameters["@iID_EVENTO"].Value.ToString());
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFEVENTO_Insertar' reportó el error Codigo: " + _codError);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::Insertar::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
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
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_Actualizar]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_EVENTO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_EVENTO", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_EVENTO", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_CALENDARIO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_CALENDARIO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_RESERVACION));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_LUNES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_LUNES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_MARTES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_MARTES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_MIERCOLES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_MIERCOLES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_JUEVES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_JUEVES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_VIERNES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_VIERNES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_SABADO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_SABADO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_DOMINGO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_DOMINGO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFEVENTO_Actualizar' reportó el error Codigo: " + _codError);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::Actualizar::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
        }


        /// <summary>
        /// Propósito: Método Update para actualizar una o más filas utilizando la llave foránea 'FKY_CALENDARIO.
        /// Este método actualiza una o más filas existentes en la base de datos, actualiza el campo 'FKY_CALENDARIO' en
        /// todas las filas que tienen ese valor para este campo con el valor 'FKY_CALENDARIOanterior 
        /// con el valor colocado en la propiedad 'FKY_CALENDARIO'.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>FKY_CALENDARIO</LI>
        ///		 <LI>FKY_CALENDARIOOld</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public bool ActualizarTodos_Con_FKY_CALENDARIO_FK()
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_ActualizarTodos_Con_FKY_CALENDARIO_FK]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_CALENDARIO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_CALENDARIO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_CALENDARIOOld", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_CALENDARIOOld));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento almacenado 'pr_UDGDFEVENTO_ActualizarTodos_Con_FKY_CALENDARIO_FK' reportó el error Código: " + _codError);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::ActualizarTodos_Con_FKY_CALENDARIO_FK::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
        }


        /// <summary>
        /// Propósito: Método Update para actualizar una o más filas utilizando la llave foránea 'FKY_RESERVACION.
        /// Este método actualiza una o más filas existentes en la base de datos, actualiza el campo 'FKY_RESERVACION' en
        /// todas las filas que tienen ese valor para este campo con el valor 'FKY_RESERVACIONanterior 
        /// con el valor colocado en la propiedad 'FKY_RESERVACION'.
        /// </summary>
        /// <returns>True si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>FKY_RESERVACION</LI>
        ///		 <LI>FKY_RESERVACIONOld</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public bool ActualizarTodos_Con_FKY_RESERVACION_FK()
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_ActualizarTodos_Con_FKY_RESERVACION_FK]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_RESERVACION));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_RESERVACIONOld", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_RESERVACIONOld));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento almacenado 'pr_UDGDFEVENTO_ActualizarTodos_Con_FKY_RESERVACION_FK' reportó el error Código: " + _codError);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::ActualizarTodos_Con_FKY_RESERVACION_FK::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
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
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_Eliminar]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_EVENTO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFEVENTO_Eliminar' reportó el error Codigo: " + _codError);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::Eliminar::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
        }


        /// <summary>
        /// Propósito: Método Eliminar para una llave primaria. Este método va a borrar una o más filas en la base de datos, basado en la llave primaria 'FKY_CALENDARIO'
        /// </summary>
        /// <returns>True si tuvo éxito, false otherwise. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>FKY_CALENDARIO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public bool EliminarTodo_Con_FKY_CALENDARIO_FK()
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_EliminarTodo_Con_FKY_CALENDARIO_FK]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_CALENDARIO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_CALENDARIO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento almacenado 'pr_UDGDFEVENTO_EliminarTodo_Con_FKY_CALENDARIO_FK' reportó el error Código: " + _codError);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::EliminarTodo_Con_FKY_CALENDARIO_FK::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
        }


        /// <summary>
        /// Propósito: Método Eliminar para una llave primaria. Este método va a borrar una o más filas en la base de datos, basado en la llave primaria 'FKY_RESERVACION'
        /// </summary>
        /// <returns>True si tuvo éxito, false otherwise. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>FKY_RESERVACION</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public bool EliminarTodo_Con_FKY_RESERVACION_FK()
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_EliminarTodo_Con_FKY_RESERVACION_FK]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_RESERVACION));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento almacenado 'pr_UDGDFEVENTO_EliminarTodo_Con_FKY_RESERVACION_FK' reportó el error Código: " + _codError);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::EliminarTodo_Con_FKY_RESERVACION_FK::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
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
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_SeleccionarUno]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFEVENTO");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_EVENTO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFEVENTO_SeleccionarUno' reportó el error Código: " + _codError);
                }

                if (toReturn.Rows.Count > 0)
                {
                    _iD_EVENTO = (Int32)toReturn.Rows[0]["ID_EVENTO"];
                    _dSC_EVENTO = (string)toReturn.Rows[0]["DSC_EVENTO"];
                    _nOM_EVENTO = (string)toReturn.Rows[0]["NOM_EVENTO"];
                    _fKY_CALENDARIO = (Int32)toReturn.Rows[0]["FKY_CALENDARIO"];
                    _fKY_RESERVACION = (Int32)toReturn.Rows[0]["FKY_RESERVACION"];
                    _cOD_LUNES = (bool)toReturn.Rows[0]["COD_LUNES"];
                    _cOD_MARTES = (bool)toReturn.Rows[0]["COD_MARTES"];
                    _cOD_MIERCOLES = (bool)toReturn.Rows[0]["COD_MIERCOLES"];
                    _cOD_JUEVES = (bool)toReturn.Rows[0]["COD_JUEVES"];
                    _cOD_VIERNES = (bool)toReturn.Rows[0]["COD_VIERNES"];
                    _cOD_SABADO = (bool)toReturn.Rows[0]["COD_SABADO"];
                    _cOD_DOMINGO = (bool)toReturn.Rows[0]["COD_DOMINGO"];
                }
                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::SeleccionarUno::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
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
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_SeleccionarTodos]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFEVENTO");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFEVENTO_SeleccionarTodos' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::SeleccionarTodos::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
        }


        /// <summary>
        /// Propósito: Método SELECT para una llave primaria. Este método hace Select de una o más filas de la base de datos, basado en la llave primaria 'FKY_CALENDARIO'
        /// </summary>
        /// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>FKY_CALENDARIO</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public DataTable SeleccionarTodos_Con_FKY_CALENDARIO_FK()
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_SeleccionarTodos_Con_FKY_CALENDARIO_FK]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFEVENTO");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_CALENDARIO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_CALENDARIO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFEVENTO_SeleccionarTodos_Con_FKY_CALENDARIO_FK' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. Le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::SeleccionarTodos_Con_FKY_CALENDARIO_FK::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
        }


        /// <summary>
        /// Propósito: Método SELECT para una llave primaria. Este método hace Select de una o más filas de la base de datos, basado en la llave primaria 'FKY_RESERVACION'
        /// </summary>
        /// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
        /// <remarks>
        /// Propiedades necesarias para este método: 
        /// <UL>
        ///		 <LI>FKY_RESERVACION</LI>
        /// </UL>
        /// Propiedades actualizadas luego de una llamada exitosa a este método: 
        /// <UL>
        ///		 <LI>CodError</LI>
        /// </UL>
        /// </remarks>
        public DataTable SeleccionarTodos_Con_FKY_RESERVACION_FK()
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_SeleccionarTodos_Con_FKY_RESERVACION_FK]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFEVENTO");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_RESERVACION));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFEVENTO_SeleccionarTodos_Con_FKY_RESERVACION_FK' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. Le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::SeleccionarTodos_Con_FKY_RESERVACION_FK::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
        }


        /// <summary>
        /// Propósito: Método Buscar. Este método hace una busqueda de acuerdo con todos los campos de la tabla.
        /// </summary>
        /// <returns>DataTable si tuvo éxito, sino genera una Exception. </returns>
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
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFEVENTO_Buscar]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFEVENTO");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_EVENTO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_EVENTO", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_EVENTO", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_EVENTO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_CALENDARIO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_CALENDARIO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_RESERVACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_RESERVACION));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_LUNES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_LUNES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_MARTES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_MARTES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_MIERCOLES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_MIERCOLES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_JUEVES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_JUEVES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_VIERNES", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_VIERNES));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_SABADO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_SABADO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_DOMINGO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_DOMINGO));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFEVENTO_Buscar' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFEVENTOBase::Buscar::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
        }


        #region Declaraciones de propiedades de la clase
        public SqlInt32 ID_EVENTO
        {
            get
            {
                return _iD_EVENTO;
            }
            set
            {
                SqlInt32 iD_EVENTOTmp = (SqlInt32)value;
                if (iD_EVENTOTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("ID_EVENTO", "ID_EVENTO can't be NULL");
                }
                _iD_EVENTO = value;
            }
        }


        public SqlString DSC_EVENTO
        {
            get
            {
                return _dSC_EVENTO;
            }
            set
            {
                SqlString dSC_EVENTOTmp = (SqlString)value;
                if (dSC_EVENTOTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("DSC_EVENTO", "DSC_EVENTO can't be NULL");
                }
                _dSC_EVENTO = value;
            }
        }


        public SqlString NOM_EVENTO
        {
            get
            {
                return _nOM_EVENTO;
            }
            set
            {
                SqlString nOM_EVENTOTmp = (SqlString)value;
                if (nOM_EVENTOTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("NOM_EVENTO", "NOM_EVENTO can't be NULL");
                }
                _nOM_EVENTO = value;
            }
        }


        public SqlInt32 FKY_CALENDARIO
        {
            get
            {
                return _fKY_CALENDARIO;
            }
            set
            {
                SqlInt32 fKY_CALENDARIOTmp = (SqlInt32)value;
                if (fKY_CALENDARIOTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("FKY_CALENDARIO", "FKY_CALENDARIO can't be NULL");
                }
                _fKY_CALENDARIO = value;
            }
        }
        public SqlInt32 FKY_CALENDARIOOld
        {
            get
            {
                return _fKY_CALENDARIOOld;
            }
            set
            {
                SqlInt32 fKY_CALENDARIOOldTmp = (SqlInt32)value;
                if (fKY_CALENDARIOOldTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("FKY_CALENDARIOOld", "FKY_CALENDARIOOld can't be NULL");
                }
                _fKY_CALENDARIOOld = value;
            }
        }


        public SqlInt32 FKY_RESERVACION
        {
            get
            {
                return _fKY_RESERVACION;
            }
            set
            {
                SqlInt32 fKY_RESERVACIONTmp = (SqlInt32)value;
                if (fKY_RESERVACIONTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("FKY_RESERVACION", "FKY_RESERVACION can't be NULL");
                }
                _fKY_RESERVACION = value;
            }
        }
        public SqlInt32 FKY_RESERVACIONOld
        {
            get
            {
                return _fKY_RESERVACIONOld;
            }
            set
            {
                SqlInt32 fKY_RESERVACIONOldTmp = (SqlInt32)value;
                if (fKY_RESERVACIONOldTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("FKY_RESERVACIONOld", "FKY_RESERVACIONOld can't be NULL");
                }
                _fKY_RESERVACIONOld = value;
            }
        }


        public SqlBoolean COD_LUNES
        {
            get
            {
                return _cOD_LUNES;
            }
            set
            {
                SqlBoolean cOD_LUNESTmp = (SqlBoolean)value;
                if (cOD_LUNESTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("COD_LUNES", "COD_LUNES can't be NULL");
                }
                _cOD_LUNES = value;
            }
        }


        public SqlBoolean COD_MARTES
        {
            get
            {
                return _cOD_MARTES;
            }
            set
            {
                SqlBoolean cOD_MARTESTmp = (SqlBoolean)value;
                if (cOD_MARTESTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("COD_MARTES", "COD_MARTES can't be NULL");
                }
                _cOD_MARTES = value;
            }
        }


        public SqlBoolean COD_MIERCOLES
        {
            get
            {
                return _cOD_MIERCOLES;
            }
            set
            {
                SqlBoolean cOD_MIERCOLESTmp = (SqlBoolean)value;
                if (cOD_MIERCOLESTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("COD_MIERCOLES", "COD_MIERCOLES can't be NULL");
                }
                _cOD_MIERCOLES = value;
            }
        }


        public SqlBoolean COD_JUEVES
        {
            get
            {
                return _cOD_JUEVES;
            }
            set
            {
                SqlBoolean cOD_JUEVESTmp = (SqlBoolean)value;
                if (cOD_JUEVESTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("COD_JUEVES", "COD_JUEVES can't be NULL");
                }
                _cOD_JUEVES = value;
            }
        }


        public SqlBoolean COD_VIERNES
        {
            get
            {
                return _cOD_VIERNES;
            }
            set
            {
                SqlBoolean cOD_VIERNESTmp = (SqlBoolean)value;
                if (cOD_VIERNESTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("COD_VIERNES", "COD_VIERNES can't be NULL");
                }
                _cOD_VIERNES = value;
            }
        }


        public SqlBoolean COD_SABADO
        {
            get
            {
                return _cOD_SABADO;
            }
            set
            {
                SqlBoolean cOD_SABADOTmp = (SqlBoolean)value;
                if (cOD_SABADOTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("COD_SABADO", "COD_SABADO can't be NULL");
                }
                _cOD_SABADO = value;
            }
        }


        public SqlBoolean COD_DOMINGO
        {
            get
            {
                return _cOD_DOMINGO;
            }
            set
            {
                SqlBoolean cOD_DOMINGOTmp = (SqlBoolean)value;
                if (cOD_DOMINGOTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("COD_DOMINGO", "COD_DOMINGO can't be NULL");
                }
                _cOD_DOMINGO = value;
            }
        }
        #endregion
    }
}
