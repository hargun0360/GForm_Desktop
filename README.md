# Slidely AI Desktop G-Form Submission Application

## Overview

This project is a Windows Desktop Application built using Visual Basic in Visual Studio. It allows users to create, view, edit, and delete form submissions. Additionally, it includes a stopwatch functionality to track time spent on each submission.

## Features

- **Create New Submissions**: Allows users to fill out a form and submit their details.
- **View Submissions**: Allows users to view submitted forms.
- **Edit Submissions**: Allows users to edit existing form submissions.
- **Delete Submissions**: Allows users to delete form submissions.
- **Stopwatch**: Tracks the time spent on each form submission.
- **Keyboard Shortcuts**: Use Ctrl+S to save, Ctrl+P for previous, and Ctrl+N for next submission.
- **Form Validation**: Ensures all fields are correctly filled out before submission.

## Setup and Installation

### Prerequisites

- **Visual Studio**: Ensure Visual Studio (not Visual Studio Code) is installed on your machine.
- **.NET Framework**: The application is built using .NET Framework.

### Clone the Repository

1. **Clone the repository**

   ```bash
   git clone <repository_url>
   cd <repository_directory>
   ```

2. **Open the Project in Visual Studio**

   - Open Visual Studio.
   - Click on "Open a project or solution".
   - Navigate to the cloned repository directory and open the solution file.

3. **Build and Run the Project**

   - Build the project by clicking on "Build" in the menu and selecting "Build Solution".
   - Run the project by clicking on "Debug" and selecting "Start Debugging".

## Project Structure

```plaintext
.
├── FormApp
│   ├── CreateSubmissionForm.vb
│   ├── ViewSubmissionsForm.vb
│   ├── Form1.vb
│   └── Submission.vb
└── README.md
```

## Frontend Form Functionalities

### CreateSubmissionForm.vb

- **Form Fields**: 
  - Name
  - Email
  - Phone
  - GitHub Link
  - Stopwatch Time

- **Buttons**: 
  - Start/Resume/Pause Stopwatch
  - Submit Form

- **Keyboard Shortcuts**:
  - **Ctrl+S**: Save the form submission
  - **Ctrl+P**: View the previous submission
  - **Ctrl+N**: View the next submission
  - **Ctrl+T**: Start/Resume/Pause the stopwatch
  - **Ctrl+U**: Update the particular entry
  - **Ctrl+D**: Delete the particular entry
  - **Ctrl+V**: View the submission form

- **Validation**: Ensures all fields are correctly filled out before allowing submission.

### ViewSubmissionsForm.vb

- **Form Fields**: Display the submitted details.
- **Buttons**: 
  - Previous
  - Next
  - Edit
  - Delete

## API Endpoints

| Endpoint       | Method | Description                       | Request Body                                                                                      | Response Status | Response Example                                                                                 |
| -------------- | ------ | --------------------------------- | ------------------------------------------------------------------------------------------------- | --------------- | ----------------------------------------------------------------------------------------------- |
| /api/ping      | GET    | Check if the server is running    | None                                                                                              | 200 OK          | `{ "success": true }`                                                                           |
| /api/submit    | POST   | Submit a new form                 | `{ "Name": "John Doe", "Email": "john.doe@example.com", "Phone": "9876543210", "GithubLink": "https://github.com/johndoe", "StopwatchTime": "00:05:30" }` | 201 Created     | `{ "success": true }`                                                                           |
| /api/read      | GET    | Retrieve a form submission by index | `index` (query parameter)                                                                         | 200 OK          | `{ "Name": "John Doe", "Email": "john.doe@example.com", "Phone": "9876543210", "GithubLink": "https://github.com/johndoe", "StopwatchTime": "00:05:30" }` |
| /api/delete    | DELETE | Delete a form submission by index | `index` (query parameter)                                                                         | 200 OK          | `{ "success": true }`                                                                           |
| /api/update    | PUT    | Update an existing form submission | `index` (query parameter), `{ "Name": "Jane Doe", "Email": "jane.doe@example.com", "Phone": "9876543211", "GithubLink": "https://github.com/janedoe", "StopwatchTime": "00:04:30" }` | 200 OK          | `{ "success": true }`                                                                           |
| /api/search    | GET    | Search for form submissions by email | `email` (query parameter)                                                                         | 200 OK          | `[ { "Name": "John Doe", "Email": "john.doe@example.com", "Phone": "9876543210", "GithubLink": "https://github.com/johndoe", "StopwatchTime": "00:05:30" } ]` |

## Output

### Landing Page

![landing](https://github.com/hargun0360/Vahan_Client/assets/89998804/583a18a4-fee9-475f-a495-df1255c5d2bf)

### Create Submission Form

![create1](https://github.com/hargun0360/Vahan_Client/assets/89998804/f84d3142-d66c-4c9d-8819-7f727e45a3f9)

### View Submissions Form

![viewsubmission](https://github.com/hargun0360/Vahan_Client/assets/89998804/2a9173dc-a89a-41a4-bdca-3093580b717c)

### Validation

![validation2](https://github.com/hargun0360/Vahan_Client/assets/89998804/35a38ead-2ac0-41c3-8d02-ed87bbb0bc18)

### Edit Submissions Form

![update](https://github.com/hargun0360/Vahan_Client/assets/89998804/49e39a20-b327-4a20-8354-7839723c85e2)

## Conclusion

This project provides a comprehensive desktop application for form submissions, complete with backend API support for CRUD operations. The frontend is designed to be user-friendly and feature-rich, ensuring a smooth user experience. The use of Visual Basic in Visual Studio ensures compatibility with Windows systems and leverages the robustness of the .NET framework.

---

**Note**: Ensure that the backend server is running before testing the frontend application.
