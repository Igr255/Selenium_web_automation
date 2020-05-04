﻿using NUnit.Framework;
using Automation.Webs.Others;
using Automation.Webs.WebObjects;

namespace Automation.Webs.Tests { 
	[TestFixture]
	class TeamsChromeTest: CommonTest {
		Credentials cr = new Credentials("dlp.automation3@safeticadlptesting.onmicrosoft.com", "Password.dlp");
		Teams teams = new Teams();

		[SetUp]
		public void OneTimeSetUp() {
			Utils.initDriverChrome();
			teams.Login(cr);
			teams.GoToTeam("Test");
		}

		[Test]
		public void Test1() {
			Utils.log.Write("Starting Test1...", "TEST");
			teams.UploadFile(Teams.Location.OneDrive, "SeleniumNUnitProject.docx");
			teams.WriteMessage("File 1 Test");
		}

		[Test]
		public void Test2() {
			Utils.log.Write("Starting Test2...", "TEST");
			teams.UploadFile(Teams.Location.OneDrive, "WordFile.docx");
			teams.WriteMessage("File Word Test");
		}

		[Test]
		public void Test3() {
			Utils.log.Write("Starting Test3...", "TEST");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
			teams.WriteMessage("File Excel Test");
		}

		[Test]
		public void Test4() {
			Utils.log.Write("Starting Test4...", "TEST");
			teams.UploadFile(Teams.Location.Recent, "SeleniumNUnitProject.docx");
			teams.UploadFile(Teams.Location.Recent, "SeleniumNUnitProject.docx");
			teams.UploadFile(Teams.Location.Recent, "WordFile.docx");
			teams.UploadFile(Teams.Location.Recent, "WordFile.docx");
			teams.UploadFile(Teams.Location.Recent, "ExcelFile.xlsx");
			teams.UploadFile(Teams.Location.Recent, "ExcelFile.xlsx");
			teams.WriteMessage("File Recent Test");
		}

		[TearDown]
		public void OneTimeTearDown() {
			Utils.browserDriver.Close();
		}

	}
}