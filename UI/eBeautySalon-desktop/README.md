# eBeautySalon Desktop

Flutter Windows desktop aplikacija za administraciju.

API URL se cita preko:

```dart
String.fromEnvironment('API_BASE_URL')
```

Pokretanje:

```bash
flutter run -d windows --dart-define=API_BASE_URL=http://localhost:5000
```
