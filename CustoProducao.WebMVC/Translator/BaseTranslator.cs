using CustoProducao.Core.Translation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustoProducao.WebMVC.Translator
{
    /// <summary>
    /// Entity Translator Pattern. 
    /// Referência: https://richhewlett.com/2010/06/11/a-useful-entity-translator-pattern-object-mapper-template/
    /// </summary>
    public abstract class BaseTranslator : IEntityTranslator
    {
        public abstract bool CanTranslate(Type sourceType, Type targetType);

        public bool CanTranslate<TSource, TTarget>()
        {
            return CanTranslate(typeof(TTarget), typeof(TSource));
        }

        public abstract object Translate(Type targetType, object source);

        public TTarget Translate<TTarget>(object source)
        {
            return (TTarget)Translate(typeof(TTarget), source);
        }

        public abstract IQueryable<TTarget> Translate<TSource, TTarget>(IQueryable<TSource> source);
    }
}
