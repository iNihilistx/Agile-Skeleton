﻿CREATE TABLE Staff (
  StaffID INT PRIMARY KEY,
  StaffName VARCHAR(255) NOT NULL,
  DOB DATE NOT NULL,
  Department VARCHAR(255) NOT NULL,
  Gender VARCHAR(10) NOT NULL,
  StaffRole TEXT,
  AvailableStaff BOOLEAN NOT NULL
);

