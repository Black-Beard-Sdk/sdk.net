﻿using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;

namespace Bb.Middleware.EntryFullLogger
{

    [ExposeClass(Context = ConstantsCore.Service, ExposedType = typeof(IRequestResponseLogger), LifeCycle = IocScopeEnum.Singleton)]
    public class RequestResponseLogger : IRequestResponseLogger
    {

        public RequestResponseLogger(ILogger<RequestResponseLogger> logger)
        {
            _logger = logger;
        }
        public void Log(IRequestResponseLogModelCreator logCreator)
        {
            _logger.LogCritical(logCreator.LogString());
        }

        private readonly ILogger<RequestResponseLogger> _logger;

    }


}
