# Khóa học Làm dự án với ASP.NET Core MVC Tedu

## 1. Tổng quan

Course content

- Build a completed application from scratch
- Database design
- Admin page for management
- Frontend page for customer
- Entity framework code first
- Git source control

Technologies

- ASP.NET Core 3.1
- Entity Framework Core 3.1
- SQL Server 2019
- C# 8.0

Required skills

- HTML & CSS
- Javascript basic
- C# basic
- SQL Server basic

## 2. Tạo dự án

Tạo `solution` mới

- Mở visual studio
- Tạo dự án mới
- Tìm kiếm từ khóa `blank`
- Tạo `blank solution`, đặt tên `eShopSolution`

![Image](md_assets/eshopsolution.png)

Tạo `project` mới

- Chuột phải lên `solution`
- Chọn `new project`
- Tìm kiếm `ASP.NET Core Web Application (MVC)`
- Đặt tên `project` là `eShopSolution.WebApp`

![Image](md_assets/eshopsolution.webapp.png)

Cấu trúc thư mục `project`

- Mô hình `MVC`
- `appsettings.json`: chứa các cài đặt cho ứng dụng, có thể tạo nhiều `appsetting` cho các môi trường khác nhau như: `dev`, `prod`, `staging`, ...
- `wwwroot`: chứa các thành phần tĩnh: `css`, `js` hay `image`
- `Program.cs`: `entry point` của ứng dụng
- `Startup.cs`: Chứa các cài đặt, cấu hình, `middleware`,...
- Trong `properties`, `launchSettings.json` chứa các cấu hình chạy server, được định nghĩa tại khóa `profiles`: bao gồm `IIS Express` và tự `host`. Thường sẽ
chọn tự host

![Image](md_assets/launchsettings.png)

### 2.1. Git flow

- Tạo nhánh mới cho `git`
- `master` --> `develop`
- Phát triển tính năng mới: `feature/create_solution_folder` --> create `pull` request to `develop`
- Fix bug: `bugfix/fix_error_start` --> create `pull` request to `develop`

Tạo nhánh mới `feature/create_solution_folder` để bắt đầu xây dựng các thư mục
tương ứng với cấu trúc `N layer`

![Image](md_assets/gitflow.png)

### 2.2. Tạo cấu trúc `solution`

Thường viết theo 2 dạng:

- `N layer`: chia 3 tầng `Data`, `Business`, `Presentation`, thiết kế theo hướng dữ liệu `Data Driven Design`
- `DDD`: `Domain driven design`, thiết kế theo hướng nghiệp vụ

Trong trường hợp dự án này ta sẽ dùng mô hình `N layer`

Chọn `solution`, tạo các `project` mới

- Tạo `Class Library (.NET Core)`, đặt tên `eShopSolution.Data` (Data)
- Tạo `Class Library (.NET Core)`, đặt tên `eShopSolution.Application` (Business)

![Image](md_assets/createsoltionfolder.png)

### 2.3. Web Application | Request pipeline

## 3. Thiết kế chức năng hệ thống

Áp dụng mô hình `agile/scrum`

Các loại thiết kế:

- Thiết kế cấu trúc dữ liệu
- Thiết kế `architect`
- Thiết kế giải thuật

Tạo `user stories`

- Customer want to have a good UI design
- Customer want to have a good SEO website
- Customer want to show list products
- Customer want to classify the products (1 product will belong to 1 or multiple categories)
- Customer want to make multiple-levels for prouct categories
- Customer want to sell online on website
- Customer want to easy manage all products
- Customer want to have members
- Customer want to control access from `admin`
- Customer want to intergrate payment online
- Customer want to intergrate login with Google and Facebook
- Customer want to show product detail (unique code, name, description, price, warranty,...)
- Customer want to have promotion? sales?
- Customer want to have multiple-languages
- Customer want to have multiple-images for each product
- Customer want to have contact information

Tạo các `functions` (chức năng) từ `user stories`

- Customer want to have a good UI design
  - Design UI for all pages
  - HTML support SEO (title, heading, alt, description,...)

- Customer want to show list products
  - List products
  - Product details

- Customer want to sell online on website
  - Cart
  - Orders

- Customer want to control access from `admin`
  - Admin page (manage products, categories)

- Customer want to have members
  - Login
  - Register
  - Manage users
  - Permission

- Customer want to intergrate payment online
  - Transaction
  - Payment intergration
- Customer want to intergrate login with Google and Facebook
  - External login intergration

- Customer want to have promotion? sales?
  - Promotion

- Customer want to have multiple-languages
  - Multiple languages

Phân rã chức năng thành 2 phân hệ: `admin page` và `customer page`

Các chức năng thuộc phân hệ `admin`

- Login
- Logout
- Menu
- UI for admin
- Show login information
- Change password for admin
- Manage product
- Manage product categories
- Manage members
- Manage orders
- Manage transactions information
- Manage permission

Các chức năng thuộc phân hệ `customer` (trang `website`)

- UI HTML
- List product categories
- Show product by categories
- Product details
- Cart
- Login
- Register
- Show information
- Change password
- Forgot password
- Logout
- Checkout
- Payment confirmation
- Profile/list orders
- Contact
- Search
