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
