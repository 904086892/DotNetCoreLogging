using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreLogging.Models;
using Microsoft.Extensions.Logging;

namespace DotNetCoreLogging.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 日志对象
        /// </summary>
        private readonly ILogger logger;
       

        public HomeController(ILoggerFactory loggerFactory)
        {
            this.logger = loggerFactory.CreateLogger<HomeController>();
        }

        public IActionResult Index()
        {
            logger.LogTrace("开发阶段调试，可能包含敏感程序数据",1);
            logger.LogDebug("开发阶段短期内比较有用，对调试有益。");
            logger.LogInformation("你访问了首页。跟踪程序的一般流程。");
            logger.LogWarning("警告信息！因程序出现故障或其他不会导致程序停止的流程异常或意外事件。");
            logger.LogError("错误信息。因某些故障停止工作");
            logger.LogCritical("程序或系统崩溃、遇到灾难性故障！！！");


            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
