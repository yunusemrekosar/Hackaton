// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const registerOpen = () => {
	let btn = document.querySelector('.register');
	let main = document.querySelector('header');
	let reg = document.querySelector('.registerCon');
	btn.addEventListener('click', () => {
		main.classList.toggle('blur');
		reg.classList.toggle('hidden');
		reg.innerHTML = `
        <div
				class="d-grid bg-transparent justify-content-center align-items-center vh-100 vw-100 z-5  gap-3 ">
				<div class="col d-flex flex-column gap-5 " style='z-index:10'>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">AD</h3>
						<input
							type="text"
							id="name" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">SOYAD</h3>
						<input
							type="text"
							id="surname" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">E-MAİL</h3>
						<input
							type="email"
							id="email" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<a
							class="nav-link btn btn-dark h-75 text-white close"
							onclick="registerClose()"
							>GERİ</a
						>
						<input
							class="btn btn-light"
							type="button"
							value="KAYIT OL" />
					</div>
				</div>
			</div>
        `;
	});
};

const registerClose = () => {
	let main = document.querySelector('header');
	let reg = document.querySelector('.registerCon');
	let btn2 = document.querySelector('.close');
	btn.addEventListener('click', () => {
		main.classList.toggle('blur');
		reg.classList.toggle('hidden');
		reg.innerHTML = '';
	});
};
