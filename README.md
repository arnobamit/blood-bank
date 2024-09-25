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
