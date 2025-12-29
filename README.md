# Unity LiveOps Demo: Simple Miner

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Firebase](https://img.shields.io/badge/Firebase-Messaging-orange.svg)](https://firebase.google.com/)


A technical portfolio project demonstrating the integration of essential LiveOps features, specifically **In-App Purchases (IAP)** and **Push Notifications** within a Unity environment.
While the project features a functional clicker game loop, the primary focus is on the architecture and implementation of backend services required for mobile game retention and monetization.

## Gameplay Overview

The project is wrapped in a simple "Clicker" mechanic:
* **Core Loop:** The main scene features a pickaxe and a stone. Clicking the stone mines ore, updating the UI counter.
* **Economy:** Ore serves as the currency to validate purchase flows.
* **Store UI:** A dedicated interface allowing users to purchase virtual currency packs.

## Technical Features

### 1. Unity IAP Integration
Integrated `Unity IAP` Service to handle real-money transactions.
* **Catalog Configuration:** Products are defined within the Unity IAP Catalog.
* **Product Logic:** Implemented 3 distinct consumable products (Currency Packs).
* **Purchase Flow:**
  1. User clicks a product button in the Store UI.
  2. App communicates with the underlying store (Google Play/App Store/FakeStore).
  3. On successful transaction callback, the `Ore` amount is programmatically incremented.

### 2. Firebase Cloud Messaging (FCM) & Analytics
Integrated the **Firebase SDK** to handle user retention via push notifications.
* **Initialization:** Firebase dependencies are initialized on `Start` to ensure services are ready before gameplay begins.
* **Permissions:** Implemented the logic to request Notification Permissions from the user immediately upon initialization (crucial for iOS and Android 13+).
* **Retention Campaign:** Configured a "Daily Engagement" notification via the Firebase Console.
  * *Logic:* Triggers a notification if the user has not logged a session (interacted with the app) in the last 24 hours.
