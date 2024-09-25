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
![Screenshot 2024-09-20 212539](https://github.com/user-attachments/assets/b59007ff-d247-4ed4-a995-d3f1f9f01303)
![Screenshot 2024-09-20 212705](https://github.com/user-attachments/assets/b2686516-685d-4407-9b49-496dcd785bfd)
![Screenshot 2024-09-20 212805](https://github.com/user-attachments/assets/d3a411a2-e759-4537-9cc7-59d9abf01de2)
![Screenshot 2024-09-20 212939](https://github.com/user-attachments/assets/5b3b64ff-c206-462d-8e2d-2c6b32ed559e)
![Screenshot 2024-09-20 213015](https://github.com/user-attachments/assets/6312dcf6-4276-454e-b02e-2c95f4263c79)
![Screenshot 2024-09-20 213121](https://github.com/user-attachments/assets/36664f15-0f15-43df-ac77-35ce60e8b242)
![Screenshot 2024-09-20 213248](https://github.com/user-attachments/assets/1780f2a2-c995-4da7-939c-5396b1f6d144)
![Screenshot 2024-09-20 213333](https://github.com/user-attachments/assets/7d364c39-0563-4ffa-b988-926080fcb985)
![Screenshot 2024-09-20 213717](https://github.com/user-attachments/assets/f6badc6f-a32f-4e5a-825a-7ab42f6c2257)
![Screenshot 2024-09-20 213948](https://github.com/user-attachments/assets/72f9cfcd-bb09-4235-9a0a-e42c7ea78038)
![Screenshot 2024-09-20 214019](https://github.com/user-attachments/assets/6005c161-32e8-484a-a0d5-93a4c04d36d9)
![Screenshot 2024-09-20 214118](https://github.com/user-attachments/assets/3bdd1c0d-0557-4f26-be9d-db205875158e)
![Screenshot 2024-09-20 214248](https://github.com/user-attachments/assets/ab7cf57b-a280-41c0-8c56-fad3afad5d28)
![Screenshot 2024-09-20 214539](https://github.com/user-attachments/assets/f7b2543a-1fcd-449c-ba3d-ea52aff7b97d)
![Screenshot 2024-09-20 214606](https://github.com/user-attachments/assets/9de7cba5-fea9-4ba2-8e8d-d2e406d2a1fc)
![Screenshot 2024-09-20 214652](https://github.com/user-attachments/assets/0a050eea-2d96-4a7f-8be2-ef6a537d232d)
![Screenshot 2024-09-20 214725](https://github.com/user-attachments/assets/d12266b7-0199-4e43-8431-84cb6c9025dc)
![Screenshot 2024-09-20 214833](https://github.com/user-attachments/assets/2d158f91-2e42-48ec-9579-305a3aff8d09)
![Screenshot 2024-09-20 214847](https://github.com/user-attachments/assets/f91ff6ee-379f-4a28-86f2-3f8da25a6a8e)
![Screenshot 2024-09-20 215158](https://github.com/user-attachments/assets/b340a8c5-dddd-43ae-935f-bbcd718c1a21)
![Screenshot 2024-09-20 212412](https://github.com/user-attachments/assets/2c5dae8d-af03-419e-bd2d-9e3f382c689d)
