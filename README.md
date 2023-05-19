# Basic-network-programming-project
### Nguyên lý hoạt động
1. Khi đăng ký trên client: Nhận thông tin tài khoản, sau đó gửi tên user và password tới server để tạo tài khoản nếu tạo thành công server trả về true, không thành công thì trả về false.
2. Khi server nhận được thông tin đăng ký từ client: Kiểm tên user đã tồn tại hay chưa nếu chưa tồn tại thì tạo user mới trên FTP server và ghi vào database, trả về true nếu tạo thành công
3. Khi đăng nhập trên client: Client sẽ kết nối với FTP server với tài khoản đã tạo trước đó, khi kết nối thành công thì sẽ hiện thư mục trên FTP server.
4. Quản lý trên server: Server có thể quản lý thông tin tài khoản vầ khôi phục mật khẩu.
### Những nguyên tắc khi sử dụng github
1. Chỉ làm việc trên nhánh của mình.
2. Trước khi code nên pull về để cập nhật code mới.
3. Commit rõ ràng.
3. Hoàn thành 1 cái gì đó thì tạo pull request (**Lưu ý chỉ tạo pull request không confirm**).
4. Thay đổi một cái gì đó quan trọng nên tạo bản backup.
### Những nguyên tắc khi code.
1. Tên biến đặt theo nguyên tắc con lạc đà. Ví dụ: phoneNumber, countLine,......
2. Tên class và hàm viết hoa các chữ cái đầu. Ví dụ MyFile, FormMain,.....
3. Tên toolbox cần có tiền tố. Ví dụ: textBox_Name, button_Read,...
4. Nên comment những chỗ khó hiểu.
5. Những đoạn code nào không sử dụng nữa nên xóa đi.
6. Những phần có nhiều công việc liên quan cần viết 1 class.
### Phân chia công việc
1. Viết class kết nối với SQL server (Thi)
2. Làm giao diện quản lý file. Link tham khảo: <https://www.youtube.com/watch?v=oRtME1oJD7M>, <https://www.youtube.com/watch?v=LT97kQWf7wU&list=PL-EU0JUF-XD1saII7gONUxMIbk13XkmCV&index=99> (Lê)
3. Lập trình socket client/server truyền file. Link tham khảo: <https://stackoverflow.com/questions/75936220/file-transfer-over-socket-in-c-sharp>, <https://www.c-sharpcorner.com/uploadfile/0a7dc8/file-transfer-program-using-C-Sharp-net-windows-application/> (Thái)
4. Cách làm 1 file server. Link tham khảo: <https://medium.com/@francesca.paterinaldi/building-a-simple-file-storage-server-with-net-core-ad608ca3dc05>, <https://github.com/rejetto/hfs> (Ngân)
5. Thiết kế form đăng nhập. (Thái)
