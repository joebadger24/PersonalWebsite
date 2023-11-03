using System;
using JBWebsite.Models;
using Microsoft.AspNetCore.Components;

namespace JBWebsite.Pages
{
	public class SkillsBase : ComponentBase
	{
		public List<GenericSkill> SkillList = new()
		{
			new GenericSkill
			{
				Name = "Python",
				ImgFilePath = "/Images/pythonlogo.png",
                Description = "Proficient in Python after completing the ‘Learn Python 3’ course on Codecademy. During my industrial placement, I created a Python script to improve the efficiency of data entry for large-scale bridge modelling. I also developed scripts to calculate complex and iterative engineering calculations, during my undergraduate degree. I developed some simple machine learning models using Python during the ‘Data Science Career Path’ course described below."
            },

			new GenericSkill
			{
				Name = "C#",
				ImgFilePath = "/Images/csharplogo.png",
                Description = "I am very experienced with C#. After completing the ‘Learn C#’ course on Codecademy, I completed a 12-week summer internship as a software engineer, in which I used C# to develop a Blazor web application."
            },

            new GenericSkill
            {
                Name = "C++",
                ImgFilePath = "/Images/cpplogo.png",
                Description = "I have used C++ to program Arduinos and other microcontrollers as part of my undergraduate dissertation project."
            },

            new GenericSkill
            {
                Name = "Blazor",
                ImgFilePath = "/Images/Blazorlogo.png",
                Description = "After completing the ‘Blazor: Getting Started’ course on Pluralsight, I gained experience developing a Blazor Web Server Application, as part of a summer internship. This project can be seen in more detail on the Projects tab."
            },

            new GenericSkill
            {
                Name = "ASP.Net",
                ImgFilePath = "/Images/aspnetlogo.png",
                Description = "Self-taught the basics of ASP.Net, and have built some simple MVC applications."
            },

            new GenericSkill
            {
                Name = "Django",
                ImgFilePath = "/Images/djangologo.png",
                Description = "Using William S. Vincent’s book ‘Django for Professionals’ I taught myself how to use Django as a framework to create web applications. This included creating a website and database for a bookshop."
            },

            new GenericSkill
            {
                Name = "Data Science",
                ImgFilePath = "/Images/pytorchlogo.png",
                Description = "Three weeks completing the Codecademy ‘Data Science Career Path’ course which included Python, SQL, NumPy, Pandas, data visualisation, natural language processing, and machine learning. This valuable course taught me the basics of data science and analytics."
            },

            new GenericSkill
            {
                Name = "HTML + CSS",
                ImgFilePath = "/Images/htmllogo.png",
                Description = "I have a great understanding of HTML and CSS after building and designing multiple front-end web applications. I also have experience with TailwindCSS, which is a utility-first CSS framework."
            },

        };
    }
}

