using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class Program
{
	static void Main(string[] args)
	{
		//定义文件路径
		string filepath;
		//读取文件并判断是直接拖入程序图标读取还是打开程序拖入窗体读取
		//拖入程序图标读取
		if (args.Length > 0)
		{
			FileInfo fileInfo = new FileInfo(args[0]);
			Console.WriteLine("版本号：1.0.0-public-alpha\t作者：Endlin Boeingstein（滨敔滨纵凝）\n编译时间：2022年10月23日18时45分\t协助调试：Min_mozj、SMF Drummer\n在使用本软件前请提前备份好文件，否则后果自负");
			Console.WriteLine("文件夹路径：" + fileInfo.FullName);
			filepath = fileInfo.FullName;
		}
		//打开程序拖入窗体读取
		else
		{
			Console.WriteLine("版本号：1.0.0-public-alpha\t作者：Endlin Boeingstein（滨敔滨纵凝）\n编译时间：2022年10月23日18时45分\t协助调试：Min_mozj、SMF Drummer\n在使用本软件前请提前备份好文件，否则后果自负");
			Console.WriteLine("请将想要装载图集的文件夹拖入窗体，并按回车键");
			//新功能更新而停用///Console.WriteLine("如果你的文件夹在C盘（尤其是桌面），那么请退出程序，直接将文件夹拖放到本应用的图标即可，拖窗体模式无权限修改C盘文件");
			filepath = Console.ReadLine().Trim('"');
		}

		if (File.Exists(filepath))
		{
			Console.WriteLine("已检测到为文件，请拖入文件夹，而不是单独文件");
		}
		else if (Directory.Exists(filepath))
		{
			Console.WriteLine("检测到为文件夹，处理中......");
			//创建dc实例
			DirectoryCreator dc = new DirectoryCreator();
			dc.DirectoryCreate(filepath);
		}
		//提示Done
		Console.WriteLine("Done");
		//提示按任意键继续
		Console.WriteLine("Press any key to continue...");
		//输入任意键退出
		Console.ReadLine();
	}
}
