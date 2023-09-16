# Quick Bites E-Commerce Web Application 

## Table of Contents
- [Introduction](#introduction)
- [Deployment](#deployment)
- [Product Overview](#product-overview)
- [Database Schema](#database-schema)
- [Explanation of Database Schema](#explanation-of-database-schema)
- [Captured Claims](#captured-claims)
- [Enforced Policies](#enforced-policies)

---

## Introduction

+ Welcome to the Quick Bites E-Commerce Web Application README. This document provides an overview of our application, its deployment, the product we are selling, our database schema, an explanation of our database structure, the claims we capture, and the policies we enforce.

---

## Deployment

- **Website Link**: [Quick Bites E-Commerce Web Application](https://quickbitesapp.azurewebsites.net/)

---

## Product Overview

+ At Quick Bites, we offer a wide range of delicious culinary delights. Our product offerings include a diverse menu of dishes, from appetizers to main courses and desserts.

---

## Database Schema

Our database schema primarily consists of the following tables:

- **Users**: Stores information about registered users.
- **FoodCategory**: Contains data related to Our Food Categories.
- **FoodItems**: Lists all food items for each Food Category.


---

## Explanation of Database Schema

- **Users**: This table stores user information, including their username, email, and hashed password.
- **FoodCategory** Display The categories in the restaurant like Lunch,drinks.deserts and so on and it also Provide links to view Items of each category.
- **FoodItem** Display all products for each food category for example for the drinks it contains Coffee Tea juice etc. and it include details for each one of them Availability price and others 

---

## Captured Claims

We capture the following claims for various purposes:

- **User Information**: Captured during registration and login for account management and personalization.


---

## Enforced Policies

We enforce the following policies to ensure a secure and user-friendly experience:

- **Authentication**: Users must be authenticated to place orders, protecting user accounts and order history.
- **Authorization**: Users can only access and modify their own data, enhancing data security.

---

## ERD (Entity Relationship Diagram)
![ER diagram](./ERD.png)


