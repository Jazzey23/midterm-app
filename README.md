# CampusLoop

Blazor (.NET 10) frontend with Tailwind CSS v4.

## Setup

Install Node.js (a current LTS version) and the .NET 10 SDK, then run:

```sh
npm ci
npm run css:build
dotnet build
```

In WSL, use Linux Node.js rather than Windows npm. If using nvm, run
`nvm use 24` in your terminal first.

## Development

Run the CSS watcher in one terminal:

```sh
npm run css:watch
```

Run Blazor in a second terminal:

```sh
dotnet watch
```

Write full Tailwind class names directly in `Components/**/*.razor`, for example
`class="rounded-xl bg-emerald-600 p-6 text-white"`. Avoid constructing class names
from fragments, since Tailwind scans source text for complete class names.

Edit `Styles/tailwind.css` for Tailwind imports and theme customization.
`wwwroot/tailwind.css` is generated; do not edit it directly. The app uses Tailwind only; the Bootstrap starter UI has been removed. Blazor's scoped
component CSS remains separate for framework error and reconnection UI.

## Production build

Generate the CSS before publishing so Blazor includes the latest stylesheet:

```sh
npm ci
npm run css:build
dotnet publish -c Release
```
