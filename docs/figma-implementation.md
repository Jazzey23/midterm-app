# CampusLoop Figma implementation

Source file: https://www.figma.com/design/BNU8rmJ9KU48UuQD34Yiov/Untitled

| Figma node | Screen | Implementation |
| --- | --- | --- |
| `3:2` | Marketplace | `/`, `Home`, `MarketplaceHero`, `ProductCard` |
| `3:610` | Item detail | `/items/1`, `ItemDetails`, `ProductCard` |
| `3:926` | My Listings | `/my-listings`, `Home`, `ProductCard` management actions |
| `3:1695` | Add listing modal | `ListingForm`, opened from Sell an Item or Add Listing |

Shared header/footer live in `MainLayout`; `Brand` renders the design's text/CSS logo. Feature components and their isolated styles live in `Components/Features/Marketplace`. Shared tokens and base styles are in `wwwroot/app.css`. Figma photos and SVGs are downloaded to `wwwroot/images/figma`; no temporary Figma URLs are used at runtime.

`Home` owns sample listings and UI state. The global Interactive Server route boundary permits navigation and callbacks without serializing component fragments. Listing changes survive in-app navigation, but reset on a full reload. No authentication, persistence, or seller messaging backend is implemented. Contact Seller reports this limitation in the UI. The listing form validates required fields, limits photos to JPEG/PNG/WebP up to 5 MB, and previews the selected image.

Desktop layout follows the provided frames. Tablet/mobile breakpoints and empty states are implementation assumptions; no responsive design frames were supplied. DM Sans and Manrope load through Google Fonts, with system fallbacks. The sample feed keeps the supplied design order; price sorting is interactive.

## Verification

- `dotnet build --no-restore`: succeeds with zero warnings and errors.
- Chromium inspection of marketplace, item detail, My Listings, and listing dialog.
- Browser interaction checks: search, categories, price sorting, edit, photo upload, add, sold/relist, delete confirmation, gallery zoom, contact message, modal Escape and scroll restoration.
- All visible image resources loaded; SVG intrinsic/rendered dimensions checked.
- All three routes checked at 390px wide with no horizontal overflow.

Run the project using its development launch profile (`dotnet run`). When running without a launch profile, set `ASPNETCORE_ENVIRONMENT=Development` so local build static assets are enabled. Production deployments should use published output.
