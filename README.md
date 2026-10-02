#Phan I.PHẦN LÝ THUYẾT & CÂU HỎI NGẮN

Câu 1: Cơ chế lưu trữ vùng nhớ của Value Types và Reference Types trong C#

Trong ngôn ngữ lập trình C#, việc quản lý bộ nhớ được tối ưu hóa dựa trên việc phân loại dữ liệu thành hai kiểu chính: kiểu giá trị và kiểu tham chiếu (Reference Types). Sự khác biệt căn bản giữa hai kiểu này nằm ở cách thức dữ liệu được lưu trữ, sao chép và quản lý trên hai vùng nhớ Stack và Heap.

Đối với Value Types, giá trị thực tế của biến thường được lưu trữ trực tiếp trên vùng nhớ Stack. Stack hoạt động theo cơ chế LIFO, có tốc độ truy xuất cực kỳ nhanh và được quản lý tự động theo scope của hàm. Khi một biến Value Type được gán cho một biến khác, hệ thống sẽ thực hiện thao tác sao chép toàn bộ giá trị. Do đó, hai biến này sẽ sở hữu hai vùng nhớ hoàn toàn độc lập; việc thay đổi giá trị của biến này sẽ không gây ảnh hưởng đến biến kia. Khi hàm kết thúc, các biến trên Stack tự động bị hủy mà không cần sự can thiệp của các cơ chế dọn dẹp phức tạp.

Ngược lại, Reference Types sử dụng cơ chế lưu trữ phân tách giữa hai vùng nhớ. Giá trị/đối tượng thực tế được cấp phát trên vùng nhớ Heap—vùng nhớ dùng chung có kích thước lớn hơn nhưng tốc độ truy xuất chậm hơn Stack. Trong khi đó, biến nằm trên Stack chỉ lưu trữ địa chỉ tham chiếu (địa chỉ con trỏ) trỏ tới vị trí của đối tượng đó trên Heap. Khi gán một biến Reference Type cho một biến khác, C# chỉ sao chép địa chỉ tham chiếu chứ không sao chép toàn bộ đối tượng.

Câu 2: Tính năng Init-only Properties (init) trong C# 9/10 và ứng dụng thực tế

Tính năng Init-only Properties được giới thiệu từ phiên bản C# 9 nhằm giải quyết bài toán cân bằng giữa tính bất biến của dữ liệu và tính linh hoạt khi khởi tạo đối tượng.

Cú pháp init cho phép gán giá trị cho thuộc tính chỉ trong quá trình khởi tạo đối tượng—bao gồm trong Constructor hoặc thông qua cú pháp khởi tạo đối tượng. Ngay sau khi quá trình khởi tạo hoàn tất, thuộc tính sẽ lập tức trở thành một giá trị chỉ đọc. Nếu có bất kỳ hành vi cố tình gán lại giá trị cho thuộc tính init sau đó, trình biên dịch sẽ báo lỗi ngay ở giai đoạn biên dịch.

Trong thực tế phát triển phần mềm, init được ứng dụng rộng rãi trong việc thiết kế các Data Transfer Objects (DTO), các mô hình Domain Model hoặc các cấu hình hệ thống. Đây là những nơi mà dữ liệu chỉ cần được tạo ra một lần duy nhất từ nguồn đọc (như Database hay API) và cần đảm bảo tính toàn vẹn, tuyệt đối không bị vô tình sửa đổi bởi các tầng logic khác trong ứng dụng.

Câu 3: Phân biệt sự khác nhau giữa phương thức virtual ở lớp cha và phương thức override ở lớp con khi triển khai tính Đa hình (Polymorphism).

Tính đa hình là một trong những trụ cột quan trọng của lập trình hướng đối tượng, cho phép các đối tượng thuộc các lớp khác nhau phản ứng khác nhau trước cùng một lời gọi phương thức. Trong C#, cơ chế này được triển khai chủ yếu thông qua bộ đôi từ khóa virtual ở lớp cha và override ở lớp con.

Từ khóa virtual được khai báo ở lớp cha nhằm đánh dấu rằng một phương thức "mở" cho phép các lớp dẫn xuất (lớp con) có thể định nghĩa lại (ghi đè) hành vi của nó nếu cần thiết. Điểm quan trọng của phương thức virtual là nó bắt buộc phải có phần triển khai (body) mặc định ở lớp cha. Điều này đảm bảo rằng nếu lớp con không thực hiện ghi đè, nó vẫn có thể sử dụng hành vi mặc định do lớp cha cung cấp mà không gây lỗi ứng dụng.

Trong khi đó, override được sử dụng ở lớp con để xác nhận việc thay thế hoàn toàn logic xử lý của phương thức virtual tương ứng từ lớp cha. Khi một phương thức được ghi đè bằng override, cơ chế liên kết muộn của C# sẽ hoạt động. Khi một phương thức được gọi thông qua một biến tham chiếu có kiểu dữ liệu là lớp cha nhưng thực thể đối tượng bên dưới lại thuộc về lớp con, chương trình sẽ ưu tiên thi hành phiên bản phương thức được định nghĩa bằng override ở lớp con.

Câu 4: Tại sao một thành phần được khai báo là static trong Lớp (Class) lại không thể truy xuất thông qua một thể hiện (Object Instance) được tạo bằng toán tử new?

Trong ngôn ngữ C#, một thành phần (trường, phương thức, thuộc tính) được khai báo với từ khóa static sẽ mang bản chất thuộc về mức độ Lớp chứ không thuộc về mức độ Thể hiện. Việc không thể truy xuất thành phần static thông qua một thể hiện được tạo bởi toán tử new xuất phát từ hai nguyên nhân chính: bản chất quản lý bộ nhớ và định hướng thiết kế ngôn ngữ.

Về mặt quản lý bộ nhớ, khi chương trình thực thi và tải một Class, hệ thống sẽ cấp phát một vùng nhớ duy nhất cho các thành phần static trong vùng nhớ Type Metadata. Vùng nhớ này tồn tại độc lập và xuyên suốt vòng đời ứng dụng, dùng chung cho toàn bộ Class đó. Ngược lại, khi sử dụng toán tử new, hệ thống sẽ cấp phát một vùng nhớ hoàn toàn mới trên Heap dành riêng cho thể hiện đó. Vùng nhớ của Instance này chỉ chứa các biến thành phần phi-static nghĩa là các trạng thái dữ liệu riêng biệt của từng đối tượng cụ thể. Do đó, các thành phần static hoàn toàn không nằm bên trong cấu trúc bộ nhớ của bất kỳ thể hiện nào.

Về mặt thiết kế ngôn ngữ và tính minh bạch của mã nguồn, các nhà thiết kế C# cố tình cấm việc gọi thành thành phần static qua biến thể hiện để tránh gây ra sự nhầm lẫn về mặt ngữ nghĩa. Thành phần static thể hiện cho trạng thái hoặc hành vi chung của toàn thể. Nếu cho phép truy xuất static qua một thể hiện cụ thể, người đọc mã nguồn có thể hiểu nhầm rằng thao tác đó chỉ tác động đến trạng thái riêng của đối tượng đó. Vì vậy, C# bắt buộc phải truy cập thành phần static trực tiếp thông qua tên Lớp, giúp đảm bảo mã nguồn rõ ràng, tường minh và phản ánh chính xác kiến trúc bộ nhớ bên dưới.
