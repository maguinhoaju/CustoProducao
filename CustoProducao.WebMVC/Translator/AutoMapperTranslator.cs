using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustoProducao.WebMVC.Translator
{
    public class AutoMapperTranslator : BaseTranslator
    {
        private MapperConfiguration _configurationProvider;

        private MapperConfiguration ConfigurationProvider
        {
            get
            {
                if (_configurationProvider == null)
                    _configurationProvider = new MapperConfiguration(cfg =>
                    {
                        cfg.AddProfile<WebMVCProfile>();
                    });

                return _configurationProvider;
            }
        }

        public override bool CanTranslate(Type sourceType, Type targetType)
        {
            try
            {
                var typeMap = ConfigurationProvider.FindTypeMapFor(sourceType, targetType);
                return typeMap != null;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override object Translate(Type targetType, object source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (targetType == null)
                throw new ArgumentNullException(nameof(targetType));

            return ConfigurationProvider.CreateMapper().Map(source, source.GetType(), targetType);
        }

        public override IQueryable<TTarget> Translate<TSource, TTarget>(IQueryable<TSource> source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            return source.ProjectTo<TTarget>(ConfigurationProvider);
        }
    }
}
