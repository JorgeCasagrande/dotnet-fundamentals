# Module 09 - Async / Await | Módulo 09 - Async / Await

🇬🇧 **This module introduces asynchronous programming in C#** using the `async` and `await` keywords. These features allow you to write non-blocking code that is easier to read and maintain.

🇪🇸 **Este módulo introduce la programación asíncrona en C#** utilizando las palabras clave `async` y `await`, que permiten escribir código no bloqueante de forma legible y mantenible.

---

## ❓ What is async/await? / ¿Qué es async/await?

🇬🇧 Asynchronous code allows programs to perform long-running tasks (like network calls or file access) without freezing the main thread. `async` and `await` make asynchronous operations look like synchronous code, improving readability.

🇪🇸 El código asíncrono permite que los programas realicen tareas que demoran (como llamadas a red o archivos) sin bloquear el hilo principal. `async` y `await` permiten escribir estas operaciones de forma más clara y legible.

---

## 📚 Topics / Temas

- 🇬🇧 Declaring async methods / 🇪🇸 Declarar métodos async
- 🇬🇧 Using `await` on tasks / 🇪🇸 Usar `await` en tareas
- 🇬🇧 Simulating delay with `Task.Delay()` / 🇪🇸 Simular demoras con `Task.Delay()`
- 🇬🇧 Parallel tasks with `Task.WhenAll()` / 🇪🇸 Tareas paralelas con `Task.WhenAll()`
- 🇬🇧 Handling exceptions in async code / 🇪🇸 Manejar excepciones en código async

---

## 🛠️ How to Run / Cómo ejecutar

```bash
dotnet run
