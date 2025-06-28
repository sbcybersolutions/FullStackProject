# 🧠 REFLECTION.md

## 🏗️ What We Built

We designed and optimized **InventoryHub**, a full-stack Blazor WebAssembly application with a minimal API back-end. The core functionality focused on:

- Displaying product data via `/api/productlist`
- Structuring data to include nested category information
- Ensuring robust front-end and back-end integration
- Improving performance via caching and service-based architecture
- Enforcing industry standards in code organization and JSON design

---

## 🤝 How Copilot Helped

Throughout this project, Copilot guided and contributed by:

- **Debugging compiler and runtime errors** like CS0246, CS1529, CS8802, and resolving CORS and deserialization issues
- **Refactoring code** for clarity, reuse, and proper layering between services and models
- **Implementing performance strategies**, including client-side caching and back-end memory caching
- **Modernizing the front-end**, converting raw HTTP calls into a memoized service layer
- **Ensuring correctness in routing**, JSON structure, and cross-origin permissions

---

## 🐛 Challenges and Fixes

| Challenge | Resolution |
|----------|------------|
| ❌ Incorrect API route (`/api/products`) | 🔁 Updated to `/api/productlist` in both client and server |
| ❌ CORS rejections between ClientApp and ServerApp | ✅ Configured `UseCors()` with proper origin permissions |
| ❌ JSON deserialization failure (`"<"` error) | ✅ Switched to strongly typed models and enabled case-insensitive matching |
| ❌ Redundant API calls | ✅ Introduced a memoizing `ProductService` to cache requests client-side |
| ❌ Repetitive back-end logic | ✅ Introduced `IMemoryCache` to store and reuse product data |
| ❌ Compiler errors due to top-level and namespace misuse | ✅ Moved models to dedicated files and enforced consistent structure |

---

## 🔍 Final Thoughts

This project evolved from a simple product fetcher into a well-structured, scalable, and performant full-stack solution. By resolving technical issues and gradually introducing best practices, InventoryHub is now clean, maintainable, and ready for new features like filtering, authentication, and database persistence.
