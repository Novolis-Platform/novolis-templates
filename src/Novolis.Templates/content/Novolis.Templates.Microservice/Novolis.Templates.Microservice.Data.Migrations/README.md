# Data.Migrations

EF Core migrations for **Novolis.<Service>**.

Add migrations from the repository root:

```bash
dotnet ef migrations add Initial --project Novolis.<Service>.Data.Migrations --startup-project Novolis.<Service>.Api
```

Apply:

```bash
dotnet ef database update --project Novolis.<Service>.Data.Migrations --startup-project Novolis.<Service>.Api
```

The template also uses `EnsureCreatedAsync` in Development for the SQLite demo — switch to migrations before production.
