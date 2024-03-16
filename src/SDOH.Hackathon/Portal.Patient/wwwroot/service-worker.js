
self.addEventListener('fetch', event => {
    return null;
});

self.addEventListener('push', event => {
    const payload = event.data.json();
    event.waitUntil(
        self.registration.showNotification('Patient Portal', {
            body: payload.message,
            vibrate: [100, 50, 100]
        })
    );
});

self.addEventListener('notificationclick', event => {
    event.notification.close();
    event.waitUntil(clients.openWindow());
});