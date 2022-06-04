window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Succesful')
    }
    if (type === "error") {
        toastr.error(message, 'Failed')
    }
    if (type === "info") {
        toastr.info(message, 'Info')
    }
    if (type === "warning") {
        toastr.warning(message, 'Warning')
    }
}


function startCarousel() {
    $('.owl-carousel').owlCarousel();

    var swiper = new Swiper('.blog-slider', {
        spaceBetween: 30,
        effect: 'fade',
        loop: true,
        mousewheel: {
            invert: false,
        },
        // autoHeight: true,
        pagination: {
            el: '.blog-slider__pagination',
            clickable: true,
        }
    });

}