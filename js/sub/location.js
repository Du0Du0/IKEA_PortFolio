const mapContainer = document.querySelector('#map');
const position = new kakao.maps.LatLng(33.450701, 126.570667);
const mapOption = { center: position, level: 3 };
const map = new kakao.maps.Map(mapContainer, mapOption);
const marker = new kakao.maps.Marker({ position: position });

marker.setMap(map);
