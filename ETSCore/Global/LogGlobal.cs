using ETSCore.Util;
using Microsoft.Extensions.Logging;

namespace ETSCore.Global;

public class LogGlobal {

    public static ILoggerFactory LogFactory = LogUtil.CreateLogFactory();

}