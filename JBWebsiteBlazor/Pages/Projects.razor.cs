using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Components;
using JBWebsiteBlazor.Models;
namespace JBWebsiteBlazor.Pages;

public class ProjectsBase : ComponentBase
{
	protected ReadOnlyCollection<GenericProject> ProjectList { get; } = new ReadOnlyCollection<GenericProject>
	(
		new List<GenericProject>
		{
			new GenericProject
			{
				Name = "Enhancing Neonatal Intensive Care through Mixed Reality Patient Monitoring",
				ImgFilePath = "/Images/avp_img.png",
				SummaryFilePath = "/DownloadFiles/MSc Dissertation.pdf",
				SummaryFileName = "MSc Dissertation.pdf",
				Description =
					"Recent advancements in mixed reality hardware present significant opportunities for enhancing patient care in healthcare settings. " +
					"This research explores the potential application of mixed reality in neonatal maternity wards, particularly focusing on patient monitoring. " +
					"Potential benefits include anonymity, hands-free data visualisation for improved hygiene, and the ability to view dynamic and spatial data. " +
					"Despite these potential benefits of mixed reality, its utilisation in neonatal healthcare remains limited. " +
					"This study aims to address this gap by developing a proof-of-concept mixed reality application. " +
					"The application will integrate real-time physiological patient data from cot-side monitors and other sources, along with relevant aspects of the patient’s care record. " +
					"This research involves selecting appropriate technology, conducting design workshops with clinical specialists, and developing two full-stack mixed reality applications. " +
					"Subsequently, the applications are reviewed through a user evaluation. " +
					"By introducing mixed reality technology to neonatal healthcare, this research aims to enhance patient monitoring practices and improve clinical outcomes."
			},
			
			new GenericProject
			{
				Name = "System C Support App",
				ImgFilePath = "/Images/Blazorlogo.png",
				SummaryFilePath = "/DownloadFiles/Support App Summary.pdf",
				SummaryFileName = "Support App Summary.pdf",
				Description =
					"This project was completed as part of a 12-week summer internship from June – September 2023. " +
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
				SummaryFilePath = "/DownloadFiles/BEng Dissertation.pdf",
				SummaryFileName = "BEng Dissertation.pdf",
				Description =
					"This research paper aims to investigate the potential for low-cost water level gauges and compare their accuracy to similar existing gauges. " +
					"Using an ESP32-CAM, Arduino, and ultrasonic sensor, two different gauges were developed using the Arduino IDE and C++. " +
					"The ESP-32-CAM was used to take images of the water level at regular intervals, which were then passed through an image processing software that I developed using Python. " +
					"This software could detect the depth of the water from the image, using a reference distance and edge-detecting algorithms. " +
					"The ultrasonic sensor was used with an Arduino Nano to take regular distance readings. This data was used to measure the relative change in water depth. " +
					"Both gauges worked off-grid using batteries and saved the relevant data to micro-SD cards. " +
					"The study concluded that both gauges would be suitable alternatives for existing water level gauges."
			},
		}
	);
}