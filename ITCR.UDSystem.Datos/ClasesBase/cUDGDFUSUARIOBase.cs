#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Empresa:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFUSUARIO'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: sábado, 22 de diciembre de 2012, 09:53:59 a.m.
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
	/// Propósito: Clase de acceso a datos para tabla 'UDGDFUSUARIO'.
	/// </summary>
	public class cUDGDFUSUARIOBase : cBDInteraccionBase
	{
		#region Declaraciones de miembros de la clase
			private SqlInt32		_fKY_SOLICITUD, _fKY_SOLICITUDOld, _iD_USUARIO;
			private SqlString		_nOM_USUARIO;
		#endregion


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFUSUARIOBase()
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
		///		 <LI>NOM_USUARIO</LI>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_USUARIO</LI>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Insertar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFUSUARIO_Insertar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_USUARIO", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_USUARIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_USUARIO", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _iD_USUARIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_iD_USUARIO = Int32.Parse(cmdAEjecutar.Parameters["@iID_USUARIO"].Value.ToString());
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFUSUARIO_Insertar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFUSUARIOBase::Insertar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Eliminar para una llave primaria. Este método va a borrar una o más filas en la base de datos, basado en la llave primaria 'FKY_SOLICITUD'
		/// </summary>
		/// <returns>True si tuvo éxito, false otherwise. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool EliminarTodo_Con_FKY_SOLICITUD_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFUSUARIO_EliminarTodo_Con_FKY_SOLICITUD_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento almacenado 'pr_UDGDFUSUARIO_EliminarTodo_Con_FKY_SOLICITUD_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFUSUARIOBase::EliminarTodo_Con_FKY_SOLICITUD_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método SELECT para un único campo. Este método hace Select de una fila de la base de datos, basado en  un único campo 'ID_USUARIO'
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_USUARIO</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		///		 <LI>ID_USUARIO</LI>
		///		 <LI>NOM_USUARIO</LI>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
		/// </remarks>
		public DataTable SeleccionarUno_Con_ID_USUARIO_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFUSUARIO_SeleccionarUno_Con_ID_USUARIO_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFUSUARIO");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_USUARIO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_USUARIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFUSUARIO_SeleccionarUno_Con_ID_USUARIO_FK' reportó el error Código: " + _codError);
				}

				if(toReturn.Rows.Count > 0)
				{
					_iD_USUARIO = (Int32)toReturn.Rows[0]["ID_USUARIO"];
					_nOM_USUARIO = (string)toReturn.Rows[0]["NOM_USUARIO"];
					_fKY_SOLICITUD = (Int32)toReturn.Rows[0]["FKY_SOLICITUD"];
				}
				return toReturn;
			}
			catch(Exception ex)
			{
				// Ocurrió un error. Le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFUSUARIOBase::SeleccionarUno_Con_ID_USUARIO_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
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
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFUSUARIO_SeleccionarTodos]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFUSUARIO");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFUSUARIO_SeleccionarTodos' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFUSUARIOBase::SeleccionarTodos::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método SELECT para una llave primaria. Este método hace Select de una o más filas de la base de datos, basado en la llave primaria 'FKY_SOLICITUD'
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public DataTable SeleccionarTodos_Con_FKY_SOLICITUD_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFUSUARIO_SeleccionarTodos_Con_FKY_SOLICITUD_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFUSUARIO");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFUSUARIO_SeleccionarTodos_Con_FKY_SOLICITUD_FK' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// Ocurrió un error. Le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFUSUARIOBase::SeleccionarTodos_Con_FKY_SOLICITUD_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
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
		///		 <LI>ID_USUARIO</LI>
		///		 <LI>NOM_USUARIO</LI>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable Buscar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFUSUARIO_Buscar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFUSUARIO");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_USUARIO", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_USUARIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_USUARIO", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_USUARIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFUSUARIO_Buscar' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFUSUARIOBase::Buscar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		#region Declaraciones de propiedades de la clase
		public SqlInt32 ID_USUARIO
		{
			get
			{
				return _iD_USUARIO;
			}
			set
			{
				SqlInt32 iD_USUARIOTmp = (SqlInt32)value;
				if(iD_USUARIOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_USUARIO", "ID_USUARIO can't be NULL");
				}
				_iD_USUARIO = value;
			}
		}


		public SqlString NOM_USUARIO
		{
			get
			{
				return _nOM_USUARIO;
			}
			set
			{
				SqlString nOM_USUARIOTmp = (SqlString)value;
				if(nOM_USUARIOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NOM_USUARIO", "NOM_USUARIO can't be NULL");
				}
				_nOM_USUARIO = value;
			}
		}


		public SqlInt32 FKY_SOLICITUD
		{
			get
			{
				return _fKY_SOLICITUD;
			}
			set
			{
				SqlInt32 fKY_SOLICITUDTmp = (SqlInt32)value;
				if(fKY_SOLICITUDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FKY_SOLICITUD", "FKY_SOLICITUD can't be NULL");
				}
				_fKY_SOLICITUD = value;
			}
		}
		public SqlInt32 FKY_SOLICITUDOld
		{
			get
			{
				return _fKY_SOLICITUDOld;
			}
			set
			{
				SqlInt32 fKY_SOLICITUDOldTmp = (SqlInt32)value;
				if(fKY_SOLICITUDOldTmp.IsNull )
				{
					throw new ArgumentOutOfRangeException("FKY_SOLICITUDOld", "FKY_SOLICITUDOld can't be NULL");
				}
				_fKY_SOLICITUDOld = value;
			}
		}
		#endregion
	}
}
