using CADLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginEsh
{
    /// <summary>
    /// Класс точки входа плагина, выполняющий его регистрацию
    /// </summary>
    public class CADLibPluginEntryPoint

    {
        public CADLibPluginEntryPoint() { }

        /// <summary>
        /// Статический метод регистрации плагин, вызываемый родительским приложением
        /// </summary>
        /// <param name="manager">Объект текущего окружения плагина</param>
        /// <returns>Интерфейс плагина</returns>
        public static ICADLibPlugin RegisterPlugin(PluginsManager manager)
        {

            return new Form1();

        }
    }
}
