import React from "react";


class ActorsList extends React.Component{
    constructor(props){
        super(props)
    }

    componentDidMount() {
        const { movies, actions } = this.props;

        if (movies.length === 0) {
        actions.loadMovies().catch((error) => {
        alert("Loading movies failed" + error);
        });
    }
  }




  render() {
        return (
            
        );
    }
}