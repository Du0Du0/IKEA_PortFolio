const vidsSection = document.querySelector('#vids');
const videos = vidsSection.querySelectorAll('.video');

videos.forEach((video, idx) => {
	video.addEventListener('click', (e) => {
		e.preventDefault();

		for (const video of videos) video.classList.remove('on');
		videos[idx].classList.add('on');
	});
});
