# GameDev-16CNTN

## Nhóm phát triển

- Hồ Minh Huấn - 1612224
- Nguyễn Duy Thanh - 1612628

## Nội dung

Đây là game được thực hiện trong đồ án giữa kì GameDev - 16CNTN. Nội dung chính là nhân vật chính đi giải cứu động vật đang bị nguy hiểm trong trận cháy rừng, mô phỏng lại công tác cứu rừng và động vật trong vụ cháy rừng Amazon ở Brazil vào tháng 8/2019.

## Hướng dẫn chơi

Chạy bo

Các động vật trong một khu rừng sẽ được đặt ngầu nhiễn trong một vòng lửa. Sau mỗi khoảng thời gian nhất định vòng lửa sẽ dần dần co lại. Nhiệm vụ của người chơi là đi cứu các động vật về nơi trực thăng cứu hộ ở giữa trung tâm vòng lửa.

Người chơi sẽ sử dụng các loại công cụ hỗ trợ để đẩy nhanh quá trình giải cứu.

Trò chơi sẽ cung cấp các hộp thính ngẫu nhiên rải rác khắp khu rừng để trợ giúp người chơi.

Động vật sẽ chết nếu bị chạm vào lửa. Khi được người chơi vác, động vật sẽ không bị ảnh hưởng bởi lửa.

Người chơi bắt đầu mỗi với 100HP. Mỗi lần chạm vào lửa bị trừ 10HP.

### Điều khiển nhân vật

- W: đi lên
- A: qua trái
- S: đi xuống
- D: qua phải

- R: đổi công cụ
- E: sử dụng công cụ
- Space: vác và thả động vật

### Các loại công cụ

- Bình nước: người chơi sẽ có sẵn bình nước và số lượng nước nhất định vào đầu mỗi màn chơi, người chơi có thể nhặt thêm nước qua các hộp thính ngẫu nhiên.
- Búa: người chơi nhặt búa thông qua hộp thính, dùng để phá cành cây cản đường.

### Hộp thính

Hộp thính cung cấp những thứ sau đây:

- Công cụ: búa
- Nước: sử dụng cho bình nước
- Tăng tốc

### Điều kiện thắng / thua

#### Thắng

- Người chơi cứu được tất cả các động vật trong khu rừng

#### Thua

- Có bất kì một động vật bị chết cháy.
- Người chơi bị chết cháy (hết HP).

### Vật cản

- Nhánh cây khô: người chơi sẽ bị té nếu va phải nhánh cây khô. Nếu va phải nhánh cây khi đang vác động vật thì động vật đó sẽ bị văng theo hướng người chơi đang di chuyển.

## Phiên bản Unity

2019.1.14f1

## Tham khảo

### Tài nguyên

- Sprite: https://www.spriters-resource.com/snes/harvestmoon/sheet/6791/?fbclid=IwAR2cXkUtlyaND3xpXXNjI5uXLMTE-ymLhfyDyEyrNMdjXglFTEjUw_KiFq8
- Background: https://res.cloudinary.com/arre/image/upload/c_scale,w_760,h_425,e_sharpen:100,f_auto,q_auto/v1566480265/Amazon-fire-illustration_2_qbm0su.png
- Sound: https://freesound.org/