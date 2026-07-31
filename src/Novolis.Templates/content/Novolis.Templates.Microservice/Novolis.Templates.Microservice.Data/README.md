# Data

Persistence for **Novolis.<Service>** owned stores: `AppDbContext`, entities, and EF configuration.

Must not reference `.Models` — entities are internal to this service. The Api project maps between entities and transport DTOs.

Default connection string: SQLite file `microservice.db` (override via `ConnectionStrings:Default`).
