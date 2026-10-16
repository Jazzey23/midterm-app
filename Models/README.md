# Future marketplace models

These standalone classes describe planned features; they are not connected to the UI,
a database, authentication, or persistence yet. Relationships use integer IDs, matching
the existing `Components/Features/Marketplace/Listing.cs` model.

- `User`: student profile. Authentication credentials belong in a future authentication provider.
- `Category`: reusable listing category.
- `ListingImage`: listing photo, alternative text, and zero-based display order.
- `Favorite`: a user's saved listing.
- `Conversation`: buyer and seller conversation about one listing.
- `Message`: conversation content and sender; a null `ReadAt` means unread.
- `Transaction`: agreed price and purchase status; prices use the app's currency.
- `Review`: transaction feedback from one participant about the other, rated 1–5.
- `Notification`: user alert with optional related entity IDs; a null `ReadAt` means unread.
- `Report`: moderation request concerning a listing or user.

When implementing persistence and services, enforce foreign keys, one favorite per
user/listing pair, nonnegative prices and image display orders, and valid transaction
participants. Validate review ratings (the Range attribute requires explicit validation),
allow reviews only for completed transactions, and enforce exactly one report target
(`ListingId` or `ReportedUserId`). Set completion/resolution timestamps when statuses
change; the classes do not enforce workflows themselves.

The existing demo Listing continues to store category and seller names as strings.
Migrating it to CategoryId and SellerId, mapping these models to storage, and wiring
features into the app are deferred until those features are implemented.
