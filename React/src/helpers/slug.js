
export function createMovieSlug(movie){
    const slug = `${(movie.name).replaceAll(" ","-").replaceAll(":","-").replaceAll(",","-")}--${movie.year}--${movie.id}`
    return slug;
}

export function createActorSlug(actor){
    const slug = `${(actor.name).replaceAll(" ","-").replaceAll(":","-").replaceAll(",","-")}--${actor.id}`
    return slug;
}

export function getIdBySlug(slug) {
    const array = slug.split("--");
    const id = parseInt(array[array.length - 1],10);
  return id;
}