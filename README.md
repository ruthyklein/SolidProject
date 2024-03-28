# HMO - Health Maintenance Organization

## Project Description

The HMO Appointment Management System allows users to schedule appointments with doctors and manage queues efficiently within the healthcare system.

## Entities

- **Patient**: Individuals receiving medical care.
- **Doctor**: Healthcare professionals providing medical services.
- **Queues**: Scheduled appointments or queue positions for patients.

## Routes Mapping for Patients

- **Retrieve List of Patients**:  
  `GET: https://clinic.co.il/patients`

- **Retrieve Patient by ID**:  
  `GET: https://clinic.co.il/patients/1`

- **Add a New Patient**:  
  `POST: https://clinic.co.il/patients`

- **Update Patient Details**:  
  `PUT: https://clinic.co.il/patients/1`

- **Update Patient Status**:  
  `PUT: https://clinic.co.il/patients/1/status`

## Routes Mapping for Doctors

- **Retrieve List of Doctors**:  
  `GET: https://clinic.co.il/doctors`

- **Retrieve Doctor by ID**:  
  `GET: https://clinic.co.il/doctors/1`

- **Add a New Doctor**:  
  `POST: https://clinic.co.il/doctors`

- **Update Doctor Details**:  
  `PUT: https://clinic.co.il/doctors/1`

- **Update Doctor Status**:  
  `PUT: https://clinic.co.il/doctors/1/status`

## Routes Mapping for Queues

- **Retrieve List of Queues**:  
  `GET: https://clinic.co.il/queues`

- **Retrieve Queue by ID**:  
  `GET: https://clinic.co.il/queues/1`

- **Add a New Queue**:  
  `POST: https://clinic.co.il/queues`

- **Update Queue Details**:  
  `PUT: https://clinic.co.il/queues/1`

- **Delete Queue**:  
  `DELETE: https://clinic.co.il/queues/1`
