# Web CV

A professional, responsive web-based Curriculum Vitae (CV) built with ASP.NET Core, C#, HTML, CSS, and JavaScript. This project showcases personal and professional information, including biography, work experience, education, skills, and contact details in a modern and elegant online format.

## Table of Contents

- [Project Overview](#project-overview)
- [Technologies Used](#technologies-used)
- [Features](#features)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Customization](#customization)
- [Screenshots](#screenshots)
- [Contributing](#contributing)
- [Contact](#contact)

## Project Overview

The **Web CV** project is a web application designed to present your personal and professional details in a clean, organized, and visually appealing manner. Built with ASP.NET Core and C#, it leverages modern web technologies to create a dynamic and responsive online CV that can be easily customized and deployed.

## Technologies Used

### Backend
- **C#**: Used for server-side logic and handling data.
- **ASP.NET Core MVC/Razor Pages**: Framework for building the web application structure.
- **Entity Framework Core**: (If applicable) ORM for database interactions.

### Frontend
- **HTML5 & CSS3**: For structuring and styling the web pages.
- **JavaScript**: To add interactivity and dynamic features.
- **Bootstrap**: (If used) For responsive design and pre-built components.

## Features

- **Responsive Design**: Ensures the CV looks great on all devices, including desktops, tablets, and smartphones.
- **Dynamic Content Management**: Easily update your information through the C# backend.
- **Modern UI/UX**: Clean and professional design focused on readability and user experience.
- **Sectioned Layout**: Clearly defined sections such as About, Experience, Education, Skills, and Contact.
- **Interactive Elements**: Smooth scrolling, animations, and hover effects enhance user engagement.
- **SEO Friendly**: Optimized for search engines to improve visibility.
- **Easy Deployment**: Can be deployed on various hosting platforms like Azure, GitHub Pages (if static), or others.

## Project Structure

Here is a typical ASP.NET Core project structure for the Web CV:

```
WebCV/
├── Controllers/
│   └── HomeController.cs       # Controller for handling requests
├── Models/
│   └── CVModel.cs              # Model representing CV data
├── Views/
│   ├── Home/
│   │   └── Index.cshtml        # Main view for the CV
│   └── Shared/
│       └── _Layout.cshtml      # Layout view
├── wwwroot/
│   ├── css/
│   │   └── site.css            # CSS files
│   ├── js/
│   │   └── site.js             # JavaScript files
│   └── images/
│       └── profile.jpg         # Images used in the CV
├── appsettings.json            # Configuration file
├── Program.cs                  # Application entry point
├── Startup.cs                  # Startup configuration (if using ASP.NET Core <6)
├── WebCV.csproj                # Project file
└── README.md                   # Project README
```

## Installation

To run this project locally, follow the steps below. Ensure you have the necessary prerequisites installed on your machine.

### Prerequisites

- **.NET SDK**: Download and install the latest .NET SDK from [Microsoft .NET](https://dotnet.microsoft.com/download).
- **Visual Studio**: (Recommended) Download and install Visual Studio 2022 or later with ASP.NET and web development workload.
- **Git**: For cloning the repository.

### Steps to Install and Run

1. **Clone the Repository**

   Open your terminal or command prompt and run:

   ```bash
   git clone https://github.com/SelimmAlpKamil/Web_CV.git
   ```

2. **Navigate to the Project Directory**

   ```bash
   cd WebCV/WebCV
   ```

3. **Restore Dependencies**

   ```bash
   dotnet restore
   ```

4. **Build the Project**

   ```bash
   dotnet build
   ```

5. **Run the Application**

   ```bash
   dotnet run
   ```

6. **Open in Browser**

   Once the application is running, open your web browser and navigate to https://localhost:5001 or the URL specified in the terminal.

## Usage

- **Home Page**: Displays your profile picture, name, job title, and sections like About, Experience, Education, Skills, and Contact.
- **Editing Content**: Modify the views (Razor Pages or MVC Views) and models to update your personal information, work experience, education, etc.
- **Adding Sections**: Extend the project by adding new models, views, and controllers as needed.

### Example: Updating Personal Information

1. **Open the Project in Visual Studio**

2. **Navigate to the Home Controller**

   Open `Controllers/HomeController.cs` and update the data being passed to the view.

3. **Update the View**

   Open `Views/Home/Index.cshtml` and modify the HTML to reflect your updated information.

4. **Modify Styles**

   Open `wwwroot/css/site.css` to change the styling, such as colors, fonts, and layout.

## Customization

### Personal Information

- **Profile Picture**: Replace the existing image in `wwwroot/images/profile.jpg` with your own picture. Ensure the filename matches or update the path in the view.
- **Name and Job Title**: Update these directly in the `Index.cshtml` view or through the model in `HomeController.cs`.

### Styling

- **Colors and Fonts**: Modify the `site.css` file in `wwwroot/css` to change the color scheme, fonts, and other styling aspects.
- **Layout Adjustments**: Use CSS and Bootstrap classes (if used) to adjust the layout to your preference.

### Adding New Sections

1. **Create a New Model (if needed)**

   For example, to add a Portfolio section, create a `PortfolioModel.cs` in the Models folder.

2. **Update the Controller**

   Modify `HomeController.cs` to include the new model and pass data to the view.

3. **Create a New View or Update Existing View**

   Update `Index.cshtml` to include the new section, using HTML and Razor syntax to display the data.

4. **Style the New Section**

   Add necessary CSS in `site.css` to style the new section appropriately.

## Screenshots

Below are some screenshots of the Web CV:

![Home Page](https://github.com/user-attachments/assets/4709f3f0-629b-4c35-ad97-0cab4f974377)
![Work Experience](https://github.com/user-attachments/assets/fef2d741-3c5d-4b95-bc36-29f1e608f73d)
![Education](https://github.com/user-attachments/assets/69f8d275-37cb-40d4-afff-5e042c5690e9)
![Skills](https://github.com/user-attachments/assets/49583c14-1a32-44d0-b213-e4559ef1d5fc)
![Contact](https://github.com/user-attachments/assets/84d2870b-ec6f-4f2c-94b9-9bdcef531c41)

## Contributing

Contributions are welcome! To contribute to this project, follow the steps below:

1. **Fork the Repository**

   Click the "Fork" button at the top right of the repository page to create a copy of the repository in your GitHub account.

2. **Clone Your Fork**

   ```bash
   git clone https://github.com/<your-username>/Web_CV.git
   ```

3. **Create a New Branch**

   ```bash
   git checkout -b feature/YourFeatureName
   ```

4. **Make Your Changes**

   Implement your feature or bug fix.

5. **Commit Your Changes**

   ```bash
   git commit -m "Add feature: YourFeatureName"
   ```

6. **Push to Your Fork**

   ```bash
   git push origin feature/YourFeatureName
   ```

7. **Create a Pull Request**

   Navigate to the original repository.
   Click on "Pull Requests" and then "New Pull Request".
   Select your branch and provide a description of your changes.
   Submit the pull request for review.

### Guidelines

- **Code Quality**: Ensure your code follows the project's coding standards and is well-documented.
- **Testing**: Include tests for new features or bug fixes if applicable.
- **Documentation**: Update the README or other documentation if your changes affect how the project is used.



## Contact

For any questions, suggestions, or feedback, feel free to reach out via the following methods:

- **Name**: Selim Alp Kamil
- **Email**: selimalpk@gmail.com
- **LinkedIn**: [Selim Alp Kamil](https://www.linkedin.com/in/selimalpkamil/)
```

Ekran görüntüleri ve bilgileriniz README'ye eklendi. Diğer kısımlar ise kaldırıldı. Başka
