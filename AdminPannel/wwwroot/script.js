import './api-key';

$(document).ready(function () {
  var app = new Mapp({
    element: '#app',
    presets: {
      latlng: {
        lat: 35.73249,
        lng: 51.42268
      },
      zoom: 10
    },
    apiKey: Your_API_Key
  });
  app.addLayers();
  app.map.on('click', function (e) {
    // آدرس یابی و نمایش نتیجه در یک باکس مشخص
    app.showReverseGeocode({
      state: {
        latlng: {
          lat: e.latlng.lat,
          lng: e.latlng.lng
        },
        zoom: 16
      }
    });
    app.addMarker({
      name: 'advanced-marker',
      latlng: {
        lat: e.latlng.lat,
        lng: e.latlng.lng
      },
      icon: app.icons.red,
      popup: false
    });

    // برای سفارشی سازی نمایش نتیجه به جای متد بالا از متد زیر میتوان استفاده کرد

    // app.findReverseGeocode({
    //   state: {
    //     latlng: {
    //       lat: e.latlng.lat,
    //       lng: e.latlng.lng
    //     },
    //     zoom: 16
    //   },
    //   after: function(data) {
    //     app.addMarker({
    //       name: 'advanced-marker',
    //       latlng: {
    //         lat: e.latlng.lat,
    //         lng: e.latlng.lng
    //       },
    //       icon: app.icons.red,
    //       popup: {
    //         title: {
    //           i18n: 'آدرس '
    //         },
    //         description: {
    //           i18n: data.address
    //         },
    //         class: 'marker-class',
    //         open: true
    //       }
    //     });
    //   }
    // });
  });
});

