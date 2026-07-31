# Api

HTTP composition root for **Novolis.<Service>**.

- Registers EF Core (`AppDbContext`), feature handlers, Swagger
- Maps controllers that translate HTTP ↔ `.Models` DTOs
- Seeds the sample SQLite database in Development

## Run

```bash
dotnet run --project Novolis.<Service>.Api
```

Open Swagger at `/swagger` in Development.

References: `.Models`, `.Data`, and the Core project (`Novolis.<Service>`).
