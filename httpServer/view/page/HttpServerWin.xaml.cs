﻿using csharpHelp;
using csharpHelp.util;
using csharpHelp.util.action;
using httpServer.view.util;
using httpServer.control;
using httpServer.entity;
using httpServer.model;
using httpServer.services;
using httpServer.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace httpServer.view.page {
	//public class HttpModel : ServerMd {
	//	public HttpServerGroup ctl = null;

	//	public ServerDataMd md = new ServerDataMd();

	//	public string ip = "localhost";     //
	//	public string port = "";
	//	public string urlParam = "";

	//	public string path = "";    //路径

	//	public bool isProxy = false;    //反向代理
	//	public string proxyUrl = "";

	//	public bool isTransmit = false; //端口转发
	//	public string transmitUrl = "";
	//	string _rewrite = "";
	//	public Dictionary<string, string> mapAutoRewrite = new Dictionary<string, string>();
	//	public Dictionary<string, string> mapRewrite = new Dictionary<string, string>();

	//	public string rewrite {
	//		get { return _rewrite; }
	//		set {
	//			_rewrite = value;
	//			updateRewrite();
	//		}
	//	}

	//	private void updateRewrite() {
	//		string[] arr = _rewrite.Split(new string[] { "\r\n", ";", "\n" }, StringSplitOptions.RemoveEmptyEntries);
	//		mapAutoRewrite = new Dictionary<string, string>();
	//		mapRewrite = new Dictionary<string, string>();

	//		for(int i = 0; i < arr.Length; ++i) {
	//			Regex regAuto = new Regex("^(?:-['\"‘“]?)(.*?)(?:['\"‘“]?)(?:[\\s]*=[\\s]*)(?:['\"‘“]?)([^'\"‘“]*)(?:['\"‘“]?)");
	//			Regex reg = new Regex("^(?:['\"‘“]?)(.*?)(?:['\"‘“]?)(?:[\\s]*=[\\s]*)(?:['\"‘“]?)([^'\"‘“]*)(?:['\"‘“]?)");

	//			Match matchAuto = regAuto.Match(arr[i].Trim());
	//			if(matchAuto.Groups.Count >= 3) {
	//				mapAutoRewrite[matchAuto.Groups[1].Value] = matchAuto.Groups[2].Value;
	//				//Debug.WriteLine(matchAuto.Groups[1].Value + "," + matchAuto.Groups[2].Value);
	//				continue;
	//			}

	//			Match match = reg.Match(arr[i].Trim());
	//			if(match.Groups.Count < 3) {
	//				continue;
	//			}

	//			mapRewrite[match.Groups[1].Value] = match.Groups[2].Value;
	//			//Debug.WriteLine(match.Groups[1].Value + "," + match.Groups[2].Value);
	//		}
	//	}

	//	public override void load(RegistryCtl regCtl, string subPath) {
	//		base.load(regCtl, subPath);

	//		string rootPath = AppDomain.CurrentDomain.BaseDirectory;

	//		ip = regCtl.getValue(subPath + "ip", "127.0.0.1");
	//		port = regCtl.getValue(subPath + "port", "8091");
	//		path = regCtl.getValue(subPath + "path", rootPath);
	//		urlParam = regCtl.getValue(subPath + "urlParam", "");
	//		_rewrite = regCtl.getValue(subPath + "rewrite", "");
	//	}

	//	public override void save(RegistryCtl regCtl, string subPath) {
	//		base.save(regCtl, subPath);

	//		regCtl.setValue(subPath + "ip", ip);
	//		regCtl.setValue(subPath + "port", port);
	//		regCtl.setValue(subPath + "path", path);
	//		regCtl.setValue(subPath + "urlParam", urlParam);
	//		regCtl.setValue(subPath + "rewrite", _rewrite);
	//	}

	//	public override int getMaxPort() {
	//		try {
	//			return int.Parse(port);
	//		} catch(Exception) {
	//			return base.getMaxPort();
	//		}
	//	}
	//};

	public class HttpServerMd : ServerMd {
		//[XmlValue("desc")] public string desc = "";
		[XmlAttr("ip")] public string ip = "localhost";
		[XmlAttr("port")] public int port = 0;
		[XmlValue("urlParam")] public string urlParam = "";

		[XmlValue("path")] public string path = "";

		//[XmlAttr("isRun")] public bool isRun = false;
		[XmlValue("rewrite")] public string _rewrite = "";

		//public bool isProxy = false;
		//public string proxyUrl = "";

		public HttpServerGroup ctl = null;
		//public ServerItem serverItem = null;

		public Dictionary<string, string> mapAutoRewrite = new Dictionary<string, string>();
		public Dictionary<string, string> mapRewrite = new Dictionary<string, string>();

		public string rewrite {
			get { return _rewrite; }
			set {
				_rewrite = value;
				updateRewrite();
			}
		}

		private void updateRewrite() {
			string[] arr = _rewrite.Split(new string[] { "\r\n", ";", "\n" }, StringSplitOptions.RemoveEmptyEntries);
			mapAutoRewrite = new Dictionary<string, string>();
			mapRewrite = new Dictionary<string, string>();

			for(int i = 0; i < arr.Length; ++i) {
				Regex regAuto = new Regex("^(?:-['\"‘“]?)(.*?)(?:['\"‘“]?)(?:[\\s]*=[\\s]*)(?:['\"‘“]?)([^'\"‘“]*)(?:['\"‘“]?)");
				Regex reg = new Regex("^(?:['\"‘“]?)(.*?)(?:['\"‘“]?)(?:[\\s]*=[\\s]*)(?:['\"‘“]?)([^'\"‘“]*)(?:['\"‘“]?)");

				Match matchAuto = regAuto.Match(arr[i].Trim());
				if(matchAuto.Groups.Count >= 3) {
					mapAutoRewrite[matchAuto.Groups[1].Value] = matchAuto.Groups[2].Value;
					//Debug.WriteLine(matchAuto.Groups[1].Value + "," + matchAuto.Groups[2].Value);
					continue;
				}

				Match match = reg.Match(arr[i].Trim());
				if(match.Groups.Count < 3) {
					continue;
				}

				mapRewrite[match.Groups[1].Value] = match.Groups[2].Value;
				//Debug.WriteLine(match.Groups[1].Value + "," + match.Groups[2].Value);
			}
		}

		public override void load(XmlCtl xmlCtl) {
			base.load(xmlCtl);

			string rootPath = AppDomain.CurrentDomain.BaseDirectory;

			ip = xmlCtl.attr( "ip", "127.0.0.1");
			port = xmlCtl.attrInt( "port", 8091);
			path = xmlCtl.value("path", rootPath);
			urlParam = xmlCtl.value("urlParam", "");
			_rewrite = xmlCtl.value("rewrite", "");
		}

		public override int getMaxPort() {
			return port;
		}
	}

	/// <summary>
	/// HttpServerWin.xaml 的交互逻辑
	/// http服务器
	/// </summary>
	public partial class HttpServerWin : UserControl, IPage {
		//HttpModel data = new HttpModel();
		Entity ent = null;

		//int dataIndex = 0;
		//ServerItem serverItem = null;
		//private HttpModel nowData = null;
		private HttpServerMd nowData = new HttpServerMd();
		//private List<ServerCtl> lstServerClt = new List<ServerCtl>();

		public HttpServerWin() {
			InitializeComponent();
		}

		public void init() {
			ent = Entity.getInstance();

			//txtProxy.Visibility = Visibility.Collapsed;
			//txtTransmit.Visibility = Visibility.Collapsed;

			//find ip
			List<string> lstIP = UiService.ins().getAllIp();
			cbxIp.Items.Add("0.0.0.0");
			cbxIp.Items.Add("localhost");
			cbxIp.Items.Add("127.0.0.1");
			for(int i = 0; i < lstIP.Count; ++i) {
				cbxIp.Items.Add(lstIP[i]);
			}
		}

		public ServerMd createNewModel() {
			HttpServerMd md = new HttpServerMd();
			md.port = SystemCtl.getFreePort(ent.mainMd.maxStartPort());
			//ent.mainModule.updateStartPort(md.port);

			md.desc = md.ip + ":" + md.port;
			md.path = SysConst.rootPath();
			return md;
			//return data;
		}

		public void initData(ServerMd _md) {
			HttpServerMd md = (HttpServerMd)_md;
			//ent.mainModule.updateStartPort(md.port);

			//ServerCtl ctl = new ServerCtl();
			//ctl.md = md;
			//md.ctl = ctl;

			HttpServerGroup ctl = new HttpServerGroup();
			ctl.md = md;
			md.ctl = ctl;

			if (md.isRun) {
				ctl.restartServer();
			}
		}

		public void start() {
			updateData("isRun", true);
		}

		public void stop() {
			updateData("isRun", false);
		}

		public void clear(ServerMd _md) {
			HttpServerMd md = (HttpServerMd)_md;
			md.ctl.clear();
		}

		public void updateData(ServerMd _md) {
			HttpServerMd md = (HttpServerMd)_md;
			nowData = md;

			//isEditByCode = true;
			//Debug.WriteLine("aa");

			txtDesc.Text = md.desc;

			cbxIp.Text = md.ip;
			txtPort.Text = "" + md.port;

			txtPath.Text = md.path;
			txtUrlParam.Text = md.urlParam;
			txtRewrite.Text = md.rewrite;

			//txtProxy.IsChecked = md.isProxy;
			//txtProxy.Text = md.proxyUrl;

			//txtTransmit.IsChecked = md.isTransmit;
			//txtTransmit.Text = md.transmitUrl;

			string ip = (md.ip == "0.0.0.0" ? "localhost" : md.ip);
			lblUrl.Content = "http://" + ip + ":" + md.port + "/" + md.urlParam;

			//Debug.WriteLine("bb");
			//isEditByCode = false;
		}

		public ServerMd createModel() {
			return new HttpServerMd();
			//return data;
		}

		private void lblUrl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
			ComUtil.runExe("explorer.exe", lblUrl.Content.ToString());
		}

		private void lblCopyUrl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
			Clipboard.SetDataObject(lblUrl.Content);
		}

		private void txtPath_TextChanged(object sender, TextChangedEventArgs e) {
			//serverPath = txtPath.Text + "/";
			updateData("path", txtPath.Text);
		}

		private void txtDesc_TextChanged(object sender, TextChangedEventArgs e) {
			updateData("desc", txtDesc.Text);
		}

		private void txtUrlParam_TextChanged(object sender, TextChangedEventArgs e) {
			updateData("urlParam", txtUrlParam.Text);
		}

		private void txtRewrite_TextChanged(object sender, TextChangedEventArgs e) {
			updateData("rewrite", txtRewrite.Text);
		}

		private void updateData(string name, string value) {
			//int idx = dataIndex;
			//if(idx < 0 || serverItem == null) {
			//	return;
			//}
			if (nowData == null) {
				return;
			}

			HttpServerMd md = nowData;

			switch(name) {
			case "desc": {
					md.desc = value;
					md.serverItem.Content = value;
					break;
				}
			//case "transmitUrl": md.transmitUrl = value; break;
			//case "proxyUrl": md.proxyUrl = value; break;
			case "path": md.path = value; break;
			case "urlParam": {
					md.urlParam = value;
					string ip = (md.ip == "0.0.0.0" ? "localhost" : md.ip);
					lblUrl.Content = "http://" + ip + ":" + md.port + "/" + md.urlParam;
					break;
				}
			case "rewrite": md.rewrite = value; break;
			}
		}

		private int toInt(string str, int def = 0) {
			bool isOk = int.TryParse(str, out int rst);
			if(!isOk) {
				rst = def;
			}
			return rst;
		}

		private void updateData(string name, bool value) {
			//int idx = dataIndex;
			//if(idx < 0 || serverItem == null) {
			//	return;
			//}
			if (nowData == null) {
				return;
			}

			HttpServerMd md = nowData;

			switch (name) {
			//case "isTransmit": md.isTransmit = value; break;
			//case "isProxy": md.isProxy = value; break;
			case "isRun": {
					md.isRun = value;
					//md.serverItem.Source = ent.mainWin.getServerStatusImgPath(md.isRun);
					var lastIp = md.ip;
					var lastPort = md.port;
					md.ip = cbxIp.Text;
					md.port = toInt(txtPort.Text, md.port);
					string ip = (md.ip == "0.0.0.0" ? "localhost" : md.ip);
					lblUrl.Content = "http://" + ip + ":" + md.port + "/" + md.urlParam;

					md.desc = md.desc.Replace(lastIp, md.ip);
					md.desc = md.desc.Replace(""+lastPort, ""+md.port);
					txtDesc.Text = md.desc;
					md.serverItem.Content = md.desc;

					if(value == true) {
						//lstServerClt[idx].restartServer();
						md.ctl.restartServer();
					} else {
						//lstServerClt[idx].clear();
						md.ctl.clear();
					}
					//if(md.desc == "" || ComServerCtl.isDescIp(md.desc)) {
					//	txtDesc.Text = md.ip + ":" + md.port;
					//	updateData("desc", md.ip + ":" + md.port);
					//}
					break;
				}
			}
		}

		private void cbxIp_TextChanged(object sender, TextChangedEventArgs e) {
			if(nowData == null || cbxIp.Text == nowData.ip) {
				return;
			}
			CmdServ.cfgWaitSave.send();
		}

		private void txtPort_TextChanged(object sender, TextChangedEventArgs e) {
			if(nowData == null || txtPort.Text == ""+nowData.port) {
				return;
			}
			CmdServ.cfgWaitSave.send();
		}

		//private bool isDescIp(string desc) {
		//	return Regex.IsMatch(desc, "^[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}:[0-9]{1,5}");
		//}

	}
}