using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustoProducao.WebMVC.Translator
{
    [Serializable]
    public class TranslationException : Exception
    {
        public TranslationException(string message) : base(message)
        {
        }
    }
}
