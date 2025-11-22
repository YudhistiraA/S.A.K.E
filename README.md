# SAKEWeb — ASP.NET Core MVC

SAKEWeb adalah aplikasi web berbasis **ASP.NET Core MVC** yang dirancang untuk kebutuhan akademik dan pengembangan sistem berbasis .NET. Proyek ini menggunakan arsitektur MVC standar dan telah dikonfigurasi agar mudah dijalankan secara lokal.

---

## 🚀 Features
- Arsitektur **Model–View–Controller (MVC)**.
- Routing sederhana dan mudah dikembangkan.
- Layout responsif menggunakan Bootstrap (default ASP.NET template).
- Struktur kode terorganisir.
- Siap untuk deployment di Windows, Linux, dan Docker.

---

## 🧰 Tech Stack
- **.NET 8 / ASP.NET Core MVC**
- **C#**
- Entity Framework Core (opsional)
- Bootstrap 5
- Razor Views

---

## 📦 Requirements
Pastikan telah menginstal:

1. **.NET SDK 8 atau versi terbaru**  
   https://dotnet.microsoft.com/download

2. (Opsional) **Visual Studio 2022** atau **VS Code + C# Dev Kit**

3. (Opsional) **Git**

---


## 🔧 How to Install

### 1. Clone Repository
```bash
git clone https://github.com/<username>/SAKEWeb.git


Berikut **bagian "How to Run" dalam Markdown murni**, bisa langsung kamu copy ke README:

---

````md
## ▶️ How to Run the Project

Ikuti langkah berikut untuk menjalankan aplikasi SAKEWeb di lingkungan lokal:

### 1. Masuk ke folder project
```bash
cd SAKEWeb
````

### 2. Restore dependency

```bash
dotnet restore
```

### 3. Jalankan aplikasi

```bash
dotnet run
```

Setelah proses berjalan, aplikasi akan muncul pada URL berikut (atau sesuai output terminal):

```
http://localhost:5080
https://localhost:7080
```

### 4. Menjalankan menggunakan Visual Studio

Jika memakai **Visual Studio 2022**:

1. Buka folder project → `SAKEWeb.sln`
2. Pilih configuration: **Debug**
3. Tekan tombol **F5** (Start Debugging)
   atau **Ctrl + F5** (Run without debugging)

---

### 🧪 Test Build (opsional)

```bash
dotnet build
```

---

### 🔧 Publish (opsional)

Untuk membuat versi siap deploy:

```bash
dotnet publish -c Release -o ./publish
```

Folder `publish/` berisi file siap upload ke server IIS, Linux, atau Docker.

```

---

Jika kamu ingin versi **lebih ringkas**, **lebih panjang**, atau **dengan emoji minimal**, tinggal bilang ya!
```
