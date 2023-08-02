//VISTA INDEX
var map;
var marker;
var markers;
var lat;
var long;

function initialize() {

    var latlng = new google.maps.LatLng(-31.404035608285895, -62.107864664359354);
    var options = {
        center: latlng,
        zoom: 14,
        zoomControl: true,
        zoomControlOptions: {
            style: google.maps.ZoomControlStyle.SMALL
        }
        //mapTypeId: google.maps.mapTypeId.ROADMAP
    };

    map = new google.maps.Map(document.getElementById("map"), options);

    if (navigator.geolocation) {
        position = navigator.geolocation.getCurrentPosition(
            function (position) {
                var pos = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
                map.setCenter(pos);
            },
            function () {
                window.alert("Navegación no soportada");
            });
    }

    var searchBox = new google.maps.places.SearchBox(document.getElementById('pac-input'));

    google.maps.event.addListener(searchBox, 'places_changed', function () {
        var places = searchBox.getPlaces();

        if (places.length == 0) {
            return;
        }

        //For each place, get the icon, place name, and location
        searchMarkers = [];
        var bounds = new google.maps.LatLngBounds();
        for (var i = 0, place; place = places[i]; i++) {
            var image = {
                url: place.icon,
                size: new google.maps.Size(71, 71),
                origin: new google.maps.Point(0, 0),
                anchor: new google.maps.Point(17, 34),
                scaledSize: new google.maps.Size(25, 25)
            }

            var mark = new google.maps.Marker({
                map: map,
                icon: image,
                title: place.name,
                position: place.geometry.location
            });

            searchMarkers.push(mark);

            bounds.extend(place.geometry.location);

        }

        map.fitBounds(bounds);
    });
}


function create_markers(markersParam) {
    markers = markersParam;
    markers.forEach(function (marker) {
        var latlng = new google.maps.LatLng(marker.coordinateY, marker.coordinateX);
        var marker1 = new google.maps.Marker({
            position: latlng,
            icon: '',
            map: map
        });

        marker1.eventTitle = marker.eventTitle;
        marker1.eventDescription = marker.eventDescription;
        marker1.street = marker.street;
        marker1.userId = marker.userId;
        marker1.userPhone = marker.userPhone;
        marker1.title = marker.eventCategory;
        marker1.mercadoPagoLink = marker.mercadoPagoLink;

        switch (marker.eventCategory) {
            case 'Papeles (Diarios, revistas, impresiones)':
                marker1.icon = 'images/mapIcons/1-PapelYCarton.png';
                break;
            case 'Cajas de Cartón':
                marker1.icon = 'images/mapIcons/1-PapelYCarton.png';
                break;
            case 'Cartón de uso cotidiano (Cajas de alimentos, tubitos de papel)':
                marker1.icon = 'images/mapIcons/1-PapelYCarton.png';
                break;
            case 'Envases tipo brick (lavados)':
                marker1.icon = 'images/mapIcons/1-PapelYCarton.png';
                break;
            case 'Otros Papeles y Cartones':
                marker1.icon = 'images/mapIcons/1-PapelYCarton.png';
                break;
            case 'Botellas de Vidrio':
                marker1.icon = 'images/mapIcons/2-Vidrio.png';
                break;
            case 'Tarros y frascos de conservas':
                marker1.icon = 'images/mapIcons/2-Vidrio.png';
                break;
            case 'Jarras y copas de vidrio':
                marker1.icon = 'images/mapIcons/2-Vidrio.png';
                break;
            case 'Otros Vidrios':
                marker1.icon = 'images/mapIcons/2-Vidrio.png';
                break;
            case 'Botellas de Plástico':
                marker1.icon = 'images/mapIcons/3-Plásticos.png';
                break;
            case 'Tapitas':
                marker1.icon = 'images/mapIcons/3-Plásticos.png';
                break;
            case 'Bandejas':
                marker1.icon = 'images/mapIcons/3-Plásticos.png';
                break;
            case 'Bolsas de plástico':
                marker1.icon = 'images/mapIcons/3-Plásticos.png';
                break;
            case 'Otros Plásticos':
                marker1.icon = 'images/mapIcons/3-Plásticos.png';
                break;
            case 'Aluminio (Latas)':
                marker1.icon = 'images/mapIcons/4-Metales.png';
                break;
            case 'Cobre':
                marker1.icon = 'images/mapIcons/4-Metales.png';
                break;
            case 'Hierro':
                marker1.icon = 'images/mapIcons/4-Metales.png';
                break;
            case 'Otros Metales':
                marker1.icon = 'images/mapIcons/4-Metales.png';
                break;
            case 'Pilas y baterías':
                marker1.icon = 'images/mapIcons/6-DesechosPeligrosos.png';
                break;
            case 'Aceites':
                marker1.icon = 'images/mapIcons/6-DesechosPeligrosos.png';
                break;
            case 'Residuos tecnológicos':
                marker1.icon = 'images/mapIcons/6-DesechosPeligrosos.png';
                break;
            case 'Residuos hospitalarios infecciosos':
                marker1.icon = 'images/mapIcons/6-DesechosPeligrosos.png';
                break;
            case 'Otros Desechos Peligrosos':
                marker1.icon = 'images/mapIcons/6-DesechosPeligrosos.png';
                break;
            case 'Residuos orgánicos':
                marker1.icon = 'images/mapIcons/19-Organicos.png';
                break;
            case 'Perecederos':
                marker1.icon = 'images/mapIcons/7-Alimentos.png';
                break;
            case 'No perecederos':
                marker1.icon = 'images/mapIcons/7-Alimentos.png';
                break;
            case 'Leche en polvo':
                marker1.icon = 'images/mapIcons/7-Alimentos.png';
                break;
            case 'Leche entera':
                marker1.icon = 'images/mapIcons/7-Alimentos.png';
                break;
            case 'Artículos para Bebés':
                marker1.icon = 'images/mapIcons/8-Bebés.png';
                break;
            case 'Niños':
                marker1.icon = 'images/mapIcons/9-Ropa.png';
                break;
            case 'Jóvenes':
                marker1.icon = 'images/mapIcons/9-Ropa.png';
                break;
            case 'Adultos':
                marker1.icon = 'images/mapIcons/9-Ropa.png';
                break;
            case 'Colchones y frazadas':
                marker1.icon = 'images/mapIcons/10-Hogar.png';
                break;
            case 'Higiene y limpieza':
                marker1.icon = 'images/mapIcons/10-Hogar.png';
                break;
            case 'Muebles':
                marker1.icon = 'images/mapIcons/10-Hogar.png';
                break;
            case 'Electrodomésticos':
                marker1.icon = 'images/mapIcons/10-Hogar.png';
                break;
            case 'Materiales para construcción':
                marker1.icon = 'images/mapIcons/10-Hogar.png';
                break;
            case 'Pintura':
                marker1.icon = 'images/mapIcons/10-Hogar.png';
                break;
            case 'Otros artículos para el hogar':
                marker1.icon = 'images/mapIcons/10-Hogar.png';
                break;
            case 'Computadoras':
                marker1.icon = 'images/mapIcons/11-Tecnología.png';
                break;
            case 'Celulares':
                marker1.icon = 'images/mapIcons/11-Tecnología.png';
                break;
            case 'Otros artículos tecnológicos':
                marker1.icon = 'images/mapIcons/11-Tecnología.png';
                break;
            case 'Juguetes':
                marker1.icon = 'images/mapIcons/12-Recreación.png';
                break;
            case 'Instrumentos musicales':
                marker1.icon = 'images/mapIcons/12-Recreación.png';
                break;
            case 'Artículos deportivos':
                marker1.icon = 'images/mapIcons/12-Recreación.png';
                break;
            case 'Otros artículos para recreación':
                marker1.icon = 'images/mapIcons/12-Recreación.png';
                break;
            case 'Útiles escolares y libros':
                marker1.icon = 'images/mapIcons/13-UtilesEscolares.png';
                break;
            case 'Medicamentos':
                marker1.icon = 'images/mapIcons/14-Salud.png';
                break;
            case 'Ortopedia':
                marker1.icon = 'images/mapIcons/14-Salud.png';
                break;
            case 'Sangre':
                marker1.icon = 'images/mapIcons/14-Salud.png';
                break;
            case 'Otros artículos para salud':
                marker1.icon = 'images/mapIcons/14-Salud.png';
                break;
            case 'Adopción':
                marker1.icon = 'images/mapIcons/15-Mascotas.png';
                break;
            case 'Alimento balanceado':
                marker1.icon = 'images/mapIcons/15-Mascotas.png';
                break;
            case 'Otros artículos de mascotas':
                marker1.icon = 'images/mapIcons/15-Mascotas.png';
                break;
            case 'Voluntariado':
                marker1.icon = 'images/mapIcons/18-Voluntariado.png';
                break;
            case 'Dinero':
                marker1.icon = 'images/mapIcons/17-Dinero.png';
                break;
            case "Eventos de Donar App":
                marker1.icon = 'images/mapIcons/20-Donar.png';
                break;
            default:
                marker1.icon = 'images/mapIcons/16-Otro.png';
                break;
        }

        mapMarkers.push(marker1);
        addInfoWindow(marker1);
        marker1.setMap(null);
    })
}

var values = [];
var mapMarkers = [];

function show_marker(selectedValues) {
    if (selectedValues.length == 0) {
        mapMarkers.forEach(function (marker) {
            marker.setMap(null);
        })
    }
    else {
        values = selectedValues;

        values.forEach(function (value) {

            mapMarkers.forEach(function (marker) {

                if (values.some(t => t == marker.title)) {
                    marker.setMap(map);
                }
                else
                    marker.setMap(null);
            })
        })
        values = values.splice(0, values.length);
    }
}

function addInfoWindow(marker) {
    var html;
    var url = "/profile/" + marker.userId.toString();
    if (marker.mercadoPagoLink != "") {
        if (marker.userPhone != "") {
            var whatsapplink = "https://wa.me/" + marker.userPhone.toString() + "?text=Hola!%20Me%20comunico%20por%20el%20evento%20" + marker.eventTitle.toString();
            html = "<div class='card-body' style='border-radius: 10px;'>" + "<b>" + "<h5 class='card-title'>" + marker.eventTitle + "</h5>" + "<\/b>" + "<p class='card-text'>" + marker.eventDescription + "</p>" + "<br/>" + "<h6 class='card-subtitle mb-2 text-muted'>" + marker.street + "</h6>" + "<div style='display=flex;flex-direction:row;'>" + "<a class='btn btn-dark btn-sm' style='border-radius: 30px;' href='" + url + "'>PERFIL</a>" + "<a class='btn btn-dark btn-sm' style='width:40px; height: 40px; bottom: 20px; right: 20px; background-color:#25d366; color:#FFF; border-radius: 50px; text-align: center; font-size: 20px; border: 0; margin-left:20%;' target='_blank'  href='" + whatsapplink + "'><i class='fa fa-whatsapp whatsapp-icon' style='margin-top: 25%;'></i></a>" + "<a class='btn btn-success btn-sm' style='border-radius: 30px; margin-left:20%;' target='_blank' href='" + marker.mercadoPagoLink + "'>DONAR</a>" + "</div>" + "</div>";
        }
        else {
            html = "<div class='card-body' style='border-radius: 10px;'>" + "<b>" + "<h5 class='card-title'>" + marker.eventTitle + "</h5>" + "<\/b>" + "<p class='card-text'>" + marker.eventDescription + "</p>" + "<br/>" + "<h6 class='card-subtitle mb-2 text-muted'>" + marker.street + "</h6>" + "<div style='display=flex;flex-direction:row;'>" + "<a class='btn btn-dark btn-sm' style='border-radius: 30px;' href='" + url + "'>PERFIL</a>" + "<a class='btn btn-success btn-sm' style='border-radius: 30px; margin-left:60%;' target='_blank' href='" + marker.mercadoPagoLink + "'>DONAR</a>" + "</div>" + "</div>";
        }
    }
    else {
        if (marker.userPhone != "") {
            var whatsapplink = "https://wa.me/" + marker.userPhone.toString() + "?text=Hola!%20Me%20comunico%20por%20el%20evento%20" + marker.eventTitle.toString();
            html = "<div class='card-body' style='border-radius: 10px;'>" + "<b>" + "<h5 class='card-title'>" + marker.eventTitle + "</h5>" + "<\/b>" + "<p class='card-text'>" + marker.eventDescription + "</p>" + "<br/>" + "<h6 class='card-subtitle mb-2 text-muted'>" + marker.street + "</h6>" + "<br><a class='btn btn-dark btn-sm' style='border-radius: 30px;' href='" + url + "'>PERFIL</a>" + "<a class='btn btn-dark btn-sm' style='width:40px; height: 40px; bottom: 20px; right: 20px; background-color:#25d366; color:#FFF; border-radius: 50px; text-align: center; font-size: 20px; border: 0; margin-left:15%;' target='_blank'  href='" + whatsapplink + "'><i class='fa fa-whatsapp whatsapp-icon' style='margin-top: 25%;'></i></a>" + "</div>";
        }
        else {
            html = "<div class='card-body' style='border-radius: 10px;'>" + "<b>" + "<h5 class='card-title'>" + marker.eventTitle + "</h5>" + "<\/b>" + "<p class='card-text'>" + marker.eventDescription + "</p>" + "<br/>" + "<h6 class='card-subtitle mb-2 text-muted'>" + marker.street + "</h6>" + "<br><a class='btn btn-dark btn-sm' style='border-radius: 30px;' href='" + url + "'>PERFIL</a>" + "</div>";
        }
    }
    var infoWindow = new google.maps.InfoWindow({
        content: html,
    });

    google.maps.event.addListener(marker, 'click', function () {
        infoWindow.open(map, marker);
    });
}

//WATSON ASSISTANT
function watsonAssistant() {
    window.watsonAssistantChatOptions = {
        integrationID: "c676b899-734a-4961-87ea-e1262c55f4e6", // The ID of this integration.
        region: "au-syd", // The region your integration is hosted in.
        serviceInstanceID: "6f869465-682d-4fbd-80b1-4c23a4858092", // The ID of your service instance.
        onLoad: function (instance) { instance.render(); }
    };
    setTimeout(function () {
        const t = document.createElement('script');
        t.src = "https://web-chat.global.assistant.watson.appdomain.cloud/versions/" + (window.watsonAssistantChatOptions.clientVersion || 'latest') + "/WatsonAssistantChatEntry.js";
        document.head.appendChild(t);
    });
}

//VISTA EVENTOS
var map2;
function initialize_event() {

    var latlng = new google.maps.LatLng(-31.404035608285895, -62.107864664359354);
    var options = {
        center: latlng,
        zoom: 14
        //mapTypeId: google.maps.mapTypeId.ROADMAP
    };

    map2 = new google.maps.Map(document.getElementById("map2"), options);

    if (navigator.geolocation) {
        position = navigator.geolocation.getCurrentPosition(
            function (position) {
                var pos = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
                map2.setCenter(pos);
            },
            function () {
                window.alert("Navegación no soportada");
            });
    }
}

function search_place(place) {

    var geocoder = new google.maps.Geocoder();

    geocoder.geocode({ 'address': place }, function (results, status) {
        if (status === 'OK') {
            var resultados = results[0].geometry.location,
                resultados_lat = resultados.lat(),
                resultados_long = resultados.lng();

            map2.setCenter(results[0].geometry.location);
            var marker = new google.maps.Marker({
                map: map2,
                position: results[0].geometry.location
            });
            localStorage.setItem("latitud", resultados_lat);
            localStorage.setItem("longitud", resultados_long);
        } else {
            var mensajeError = "";
            if (status === "ZERO_RESULTS") {
                mensajeError = "No hubo resultados para la dirección ingresada.";
            } else if (status === "OVER_QUERY_LIMIT" || status === "REQUEST_DENIED" || status === "UNKNOWN_ERROR") {
                mensajeError = "Error general del mapa.";
            } else if (status === "INVALID_REQUEST") {
                mensajeError = "Error de la web. Contacte con Name Agency.";
            }
            alert(mensajeError);
        }
    });
}

function addIdsToCheckboxElements() {
    let listOfElementsWithId = document.querySelectorAll(`[id^="clickEn"]`); 
    listOfElementsWithId.forEach(function (element) {
        let checkBoxInput = element.querySelector('.mud-checkbox-input');
        if (checkBoxInput) checkBoxInput.id = element.id;
        //console.log(checkBoxInput);
    })
}
