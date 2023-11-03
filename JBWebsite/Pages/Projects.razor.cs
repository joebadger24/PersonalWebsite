using System;
using JBWebsite.Models;
using Microsoft.AspNetCore.Components;

namespace JBWebsite.Pages
{
	public class ProjectsBase : ComponentBase
	{
		public List<GenericProject> ProjectList = new()
		{
			new GenericProject
			{
				Name = "System C Support App",
				ImgFilePath = "/Images/Blazorlogo.png",
				SummaryFilePath = "/DownloadFiles/SystemC_SupportApp_Outline.pdf",
				SummaryFileName = "Project Summary",
				Description = "This project was completed as part of a 12-week summer internship from June – September 2023. " +
				"This project aimed to build a web application that would act as a tool for the support team. " +
				"System C provides health information technology systems and services to the NHS and social care. " +
				"One of their services stores and manages patient and baby data for maternity and neonatal care. " +
				"When the users of this service encounter problems, they can call System C, and the support team can help to diagnose the issue. " +
				"This web app aims to create a more functional and user-friendly tool to help the support team fix problems quickly. " +
				"Blazor was used as the framework for this project due to its ability to create dynamic web applications using only C# and HTML. " +
				"Another benefit of Blazor is being able to design generic components, which can be used throughout the project, which means it is very quick to implement new functionality. " +
				"The front end was styled using Tailwind CSS, which is a utility-first CSS framework."
            },

			new GenericProject
			{
				Name = "Development of a low-cost water level gauge",
				ImgFilePath = "/Images/dissimg2.png",
				SummaryFilePath = "/DownloadFiles/Dissertation.pdf",
				SummaryFileName = "Full Dissertation",
				Description = "This research paper aims to investigate the potential for low-cost water level gauges and compare their accuracy to similar existing gauges. " +
				"Using an ESP32-CAM, Arduino, and ultrasonic sensor, two different gauges were developed using the Arduino IDE and C++. " +
				"The ESP-32-CAM was used to take images of the water level at regular intervals, which were then passed through an image processing software that I developed using Python. " +
				"This software could detect the depth of the water from the image, using a reference distance and edge-detecting algorithms. " +
				"The ultrasonic sensor was used with an Arduino Nano to take regular distance readings. This data was used to measure the relative change in water depth. " +
				"Both gauges worked off-grid using batteries and saved the relevant data to micro-SD cards. " +
				"The study concluded that both gauges would be suitable alternatives for existing water level gauges."
            }
		};
	}
}

