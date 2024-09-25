# Blood Bank Management System

## CASE STUDY

### Key Entities:
- **Donor**: Stores donor details (e.g., ID, blood type, DOB, address). Linked to **Blood Banks** through donations.
- **Patient**: Represents individuals needing blood. Managed by the **Manager**.
- **Manager**: Oversees donors and patients, assigning blood from **Blood Banks** to **Hospitals**.
- **Blood Bank**: Stores blood and details (e.g., stock, city). Connected to both donors and hospitals.
- **Hospital**: Receives blood from banks based on demand.
- **Admin**: Has control over the manager's operations.

### Key Relationships:
- **Donate**: Links donors and blood banks.
- **Manage**: Links managers with donors and patients.
- **Assign**: Handles blood distribution from banks to hospitals.

### Scenario:
A **Manager** coordinates a donation drive during a crisis, matching blood from **Donors** to **Blood Banks**, and distributing it to **Hospitals** as needed. The **Admin** ensures smooth system operations.

## Setup & Installation
### Prerequisites
- Visual Studio (or any C# IDE)
- SQL Server or any compatible database
- .NET Framework (latest version)

### Steps to Set Up:
1. **Clone the repository**:
   ```bash
   [git clone https://github.com/your-repo/blood-donation-management-system.git](https://github.com/arnobamit/blood-bank.git)

## Database Schema

Tables:

CREATE TABLE [dbo].[donor_info] (
    [d_id]       INT           IDENTITY (1, 1) NOT NULL,
    [f_name]     VARCHAR (50)  NOT NULL,
    [l_name]     VARCHAR (50)  NOT NULL,
    [d_username] VARCHAR (50)  NOT NULL,
    [d_phone]    INT           NOT NULL,
    [d_email]    VARCHAR (50)  NOT NULL,
    [d_password] VARCHAR (50)  NOT NULL,
    [d_DOB]      DATE          NOT NULL,
    [d_blood]    VARCHAR (20)  NOT NULL,
    [d_gender]   VARCHAR (20)  NOT NULL,
    [d_city]     VARCHAR (50)  NOT NULL,
    [d_address]  VARCHAR (100) NOT NULL,
    [d_image]    IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([d_id] ASC)
);

CREATE TABLE [dbo].[patient_info] (
    [p_id]      INT           IDENTITY (1, 1) NOT NULL,
    [f_name]    VARCHAR (50)  NOT NULL,
    [l_name]    VARCHAR (50)  NOT NULL,
    [p_phone]   INT           NOT NULL,
    [p_age]     VARCHAR (50)  NULL,
    [p_DOB]     DATE          NOT NULL,
    [p_blood]   VARCHAR (20)  NOT NULL,
    [p_gender]  VARCHAR (20)  NOT NULL,
    [p_city]    VARCHAR (50)  NOT NULL,
    [p_address] VARCHAR (100) NOT NULL,
    [p_email]   VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([p_id] ASC)
);

CREATE TABLE [dbo].[manager_info] (
    [m_id]       INT           IDENTITY (1, 1) NOT NULL,
    [f_name]     VARCHAR (50)  NOT NULL,
    [l_name]     VARCHAR (50)  NOT NULL,
    [m_username] VARCHAR (50)  NOT NULL,
    [m_phone]    INT           NOT NULL,
    [m_email]    VARCHAR (50)  NULL,
    [m_password] VARCHAR (50)  NOT NULL,
    [m_DOB]      DATE          NOT NULL,
    [m_blood]    VARCHAR (20)  NOT NULL,
    [m_gender]   VARCHAR (20)  NOT NULL,
    [m_city]     VARCHAR (50)  NOT NULL,
    [m_address]  VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([m_id] ASC)
);

CREATE TABLE [dbo].[register_info] (
    [r_id]       INT           IDENTITY (1, 1) NOT NULL,
    [f_name]     VARCHAR (50)  NOT NULL,
    [l_name]     VARCHAR (50)  NOT NULL,
    [r_username] VARCHAR (50)  NOT NULL,
    [r_phone]    INT           NOT NULL,
    [r_email]    VARCHAR (50)  NULL,
    [r_password] VARCHAR (50)  NOT NULL,
    [r_DOB]      DATE          NOT NULL,
    [r_blood]    VARCHAR (20)  NOT NULL,
    [r_gender]   VARCHAR (20)  NOT NULL,
    [r_city]     VARCHAR (50)  NOT NULL,
    [r_address]  VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([r_id] ASC)
);

CREATE TABLE [dbo].[hospital_info] (
    [h_id]          INT           IDENTITY (1, 1) NOT NULL,
    [hospital_name] VARCHAR (50)  NOT NULL,
    [h_stock]       INT           NOT NULL,
    [h_phone]       INT           NOT NULL,
    [h_email]       VARCHAR (50)  NOT NULL,
    [h_city]        VARCHAR (50)  NOT NULL,
    [h_address]     VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([h_id] ASC)
);

CREATE TABLE [dbo].[bb_info] (
    [bb_id]      INT           IDENTITY (1, 1) NOT NULL,
    [bb_name]    VARCHAR (100) NOT NULL,
    [bb_phone]   INT           NOT NULL,
    [bb_email]   VARCHAR (50)  NOT NULL,
    [bb_city]    VARCHAR (50)  NOT NULL,
    [bb_address] VARCHAR (100) NOT NULL,
    [bb_stock]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([bb_id] ASC)
);

## ER Diagram
![ER Diagram](https://github.com/user-attachments/assets/7033e4fd-d95c-4ad9-a1eb-6fec30e83ce3)

## GUI Interface
![Screenshot 2024-09-20 212149](https://github.com/user-attachments/assets/be538bf3-70fa-4683-b100-5d82f28f9a05)

![Screenshot 2024-09-20 212412](https://github.com/user-attachments/assets/55f81440-22bc-4084-9d7e-959c936c8ba6)

![Screenshot 2024-09-20 212539](https://github.com/user-attachments/assets/3a0cab7d-8581-42dc-bdb9-653139f1ec85)

![Screenshot 2024-09-20 212705](https://github.com/user-attachments/assets/b96e02de-fd50-4521-9c80-cb6d641ddce7)

![Screenshot 2024-09-20 212805](https://github.com/user-attachments/assets/f971a4c7-1e1e-4c5b-957c-6f6e0877a1cb)

![Screenshot 2024-09-20 212939](https://github.com/user-attachments/assets/aa5c9fa2-e1a3-481e-a210-fd52f4011729)

![Screenshot 2024-09-20 213015](https://github.com/user-attachments/assets/3c1e063c-b389-4a92-afc2-7f565636838c)

![Screenshot 2024-09-20 213121](https://github.com/user-attachments/assets/c6e2667d-fe33-42a3-9084-2ec6aa8ef8da)

![Screenshot 2024-09-20 213248](https://github.com/user-attachments/assets/5da88a8a-6b7e-4f41-86d7-2b48d8b0defb)

![Screenshot 2024-09-20 213333](https://github.com/user-attachments/assets/47eaa7f3-d582-4e17-a890-eb798b5a74c3)

![Screenshot 2024-09-20 213717](https://github.com/user-attachments/assets/a598f15f-7647-431c-8f40-0118ef06c228)

![Screenshot 2024-09-20 213948](https://github.com/user-attachments/assets/af65ec4e-6efe-41bf-a458-0f526f83a041)

![Screenshot 2024-09-20 214019](https://github.com/user-attachments/assets/f51b5d42-d5fb-4866-8fff-b6b349f1eaf2)

![Screenshot 2024-09-20 214118](https://github.com/user-attachments/assets/9376133a-d924-4751-994c-9d2886f1cb7c)

![Screenshot 2024-09-20 214248](https://github.com/user-attachments/assets/dab767a8-7825-4aae-a698-a711e68fd090)

![Screenshot 2024-09-20 214539](https://github.com/user-attachments/assets/7d7ff7e3-132a-4812-a75b-1e9129b640ce)

![Screenshot 2024-09-20 214606](https://github.com/user-attachments/assets/0853b0d8-bb1c-48a0-9d67-12d09b6f714e)

![Screenshot 2024-09-20 214652](https://github.com/user-attachments/assets/8f881dcb-9c64-48e3-be3c-24ec38d4bd53)

![Screenshot 2024-09-20 214725](https://github.com/user-attachments/assets/10005b64-4aa7-481a-8daa-b86c79af65c8)

![Screenshot 2024-09-20 214833](https://github.com/user-attachments/assets/84ccea1f-c8d2-468a-9ae8-eec9f6e9a3aa)

![Screenshot 2024-09-20 214847](https://github.com/user-attachments/assets/1919a86f-eab2-4802-95ca-b9742a6a0617)

![Screenshot 2024-09-20 215158](https://github.com/user-attachments/assets/26334232-3394-49a9-8d34-e3cc8f88a720)
