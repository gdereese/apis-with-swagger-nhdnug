/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');

gulp.task("css", function () {
    var vendorJsGlob = [
        "node_modules/bootstrap/dist/css/*.css"
    ];

    gulp.src(vendorJsGlob)
        .pipe(gulp.dest("wwwroot/css"));
});

gulp.task("js", function() {
    var vendorJsGlob = [
        "node_modules/bootstrap/dist/js/*.js",
        "node_modules/jquery/dist/jquery.js", 
        "node_modules/swagger-client/browser/*.js"
    ];

    gulp.src(vendorJsGlob)
        .pipe(gulp.dest("wwwroot/js"));
});

gulp.task('default', ["css", "js"]);