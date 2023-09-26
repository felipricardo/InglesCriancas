using System;
using System.Collections.Generic;
using System.Text;

namespace InglesCriancas
{
    /// <summary>
    /// Interface que define um contrato para fechar o aplicativo.
    /// </summary>
    public interface ICloseApplication
    {
        /// <summary>
        /// Fecha o aplicativo.
        /// </summary>
        void CloseApplication();
    }
}
