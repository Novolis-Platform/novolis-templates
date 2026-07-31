# Core

Application core for **Novolis.<Service>**: feature slices, use cases, and domain logic.

Organize handlers and domain types under `Features/<FeatureName>/`. The sample includes a `Companies` list handler wired by the Api host.

**References:** `.Data` only — not `.Models` (transport contracts stay at the Api boundary).
