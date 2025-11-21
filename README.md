# ShoppingCartApp
# ShoppingCartApp - Full Solution

This archive contains a complete .NET 8 Shopping Cart sample with:
- API (ShoppingCart.API)
- Web UI (Razor Pages) (ShoppingCart.Web)
- Domain (ShoppingCart.Core)
- Infrastructure (ShoppingCart.Infrastructure)
- Unit tests (xUnit) + Coverlet

## Important values (pre-filled)
- GHCR base: `ghcr.io/radhika-testengineer`
- Docker image name used in workflow: `ghcr.io/radhika-testengineer/shoppingcartapp`
- SonarCloud organization (use repository secret `SONAR_ORG`): `radhika-testengineer`
- Suggested SonarCloud project key (set repository secret `SONAR_PROJECT_KEY`): `Radhika-TestEngineer_ShoppingCartApp`

## Required GitHub repository secrets
Create the following in your GitHub repo (Settings → Secrets → Actions):

- `SONAR_TOKEN` - SonarCloud token (from SonarCloud > My Account > Security)
- `SONAR_ORG` - `radhika-testengineer`
- `SONAR_PROJECT_KEY` - `Radhika-TestEngineer_ShoppingCartApp`
- `GITHUB_TOKEN` - (automatically provided by GitHub Actions; used for GHCR in workflow)
- If you prefer PAT for GHCR pushes: create `GHCR_PAT` and update workflow to use it.
- For Render private registry pull:
  - `RENDER_PRIVATE_REGISTRY_USER` - your GitHub username
  - `RENDER_PRIVATE_REGISTRY_PASSWORD` - PAT with `read:packages` scope

## How to run locally
1. Build & run API:
   ```bash
   dotnet restore
   dotnet build -c Release
   dotnet run --project src/ShoppingCart.API/ShoppingCart.API.csproj
   ```
2. Run Web (in a new terminal):
   ```bash
   dotnet run --project src/ShoppingCart.Web/ShoppingCart.Web.csproj
   ```
   Ensure the API base address is reachable (default set to http://localhost:5000 in Web project's Program.cs).
3. Run tests & coverage:
   ```bash
   dotnet test tests/ShoppingCart.Tests/ShoppingCart.Tests.csproj --collect:"XPlat Code Coverage"
   ```

## Deploying
- Push repo to GitHub `main`
- Actions will run: build → test → Sonar → build image → push to GHCR
- On Render, create a Web Service and use the image `ghcr.io/radhika-testengineer/shoppingcartapp:latest`.
  For private images, provide registry credentials (username + PAT) in Render.

