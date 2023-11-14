


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
    apiKey: 'eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjY0ZmFhZDE2OTQxZmRhMDUyOGFkMDQ4MmQwMGZlMjBjY2Q2NzRmOGRmMzNmZmUxOTE3ZDQ4NzQ2ZmI4YzEyNDY5Y2JkMzBiNmJlYjNkODdhIn0.eyJhdWQiOiIxNTU4NiIsImp0aSI6IjY0ZmFhZDE2OTQxZmRhMDUyOGFkMDQ4MmQwMGZlMjBjY2Q2NzRmOGRmMzNmZmUxOTE3ZDQ4NzQ2ZmI4YzEyNDY5Y2JkMzBiNmJlYjNkODdhIiwiaWF0IjoxNjMyNTAxNDIwLCJuYmYiOjE2MzI1MDE0MjAsImV4cCI6MTYzNTAwNzAyMCwic3ViIjoiIiwic2NvcGVzIjpbImJhc2ljIl19.Dxd1tOha-wPG8LgfKjK5pRQpNDKsiDLnJ9m9J_Sq4DtOR_ngl7krt8svDrJbl58Mtnyad6LViI95qTQ5qkSwDoiUggvfHEEWVO3fklnmlQLLdXWfEQOFMQczbmWt36xoSjBKC92menpug4HFIn7_pNJhu_czq6Atd6kdeiBYceCcWruNtze7IyoGP8H0OzDpQ-PI0Y-PyEhlU5jkgwnGKgbQCZQFEnll-gIg3nPAFt2W18xuP2lbWolP17K1U-dn26eGfJT1XAcF_Gz5eq51ojR6bEwKXx2yZKKtj-gChv2CaZX1qmST98GfW1Sn_l1_YYzKT2FoDfROCaYarfplQg'

                                    });
    app.map.invalidateSize()
    app.addLayers();
    app.map.on('click', function (e) {


        app.addMarker({
            name: 'advanced-marker',
            latlng: {
                lat: e.latlng.lat,
                lng: e.latlng.lng
            },
            icon: app.icons.red,
            popup: false
        });
    $("#lat").val(e.latlng.lat);
    $("#lng").val(e.latlng.lng);
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


