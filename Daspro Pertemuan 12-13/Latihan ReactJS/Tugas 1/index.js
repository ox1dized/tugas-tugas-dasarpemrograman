const matkulAwal = [
  { index: 1, value: "Dasar Pemrograman" },
  { index: 2, value: "Matematika Dasar" },
  { index: 3, value: "Sistem dan Teknologi Informasi" },
  { index: 4, value: "Fisika Dasar" },
  { index: 5, value: "Pengantar Teknik" },
];

const hapusMatkul = (items, itemIndex) =>
  items.filter((_, i) => i !== itemIndex);

const MatkulList = ({ listMatkul, hapusMatkul }) => {
  const itemsNodes = listMatkul.map((item, index) => (
    <li key={index} className="list-group-item ">
      <div>
        {item.value}
        <button
          type="button"
          className="close"
          onClick={(e) => {
            e.stopPropagation();
            hapusMatkul(parseInt(index));
          }}
        >
          &times;
        </button>
      </div>
    </li>
  ));

  return <ul className="list-group"> {itemsNodes} </ul>;
};

const MatkulForm = ({ oninputMatkulChange, inputMatkul, onSubmit }) => {
  return (
    <form onSubmit={onSubmit} className="form-inline">
      <input
        autoFocus
        type="text"
        className="form-control"
        placeholder=""
        onChange={oninputMatkulChange}
        value={inputMatkul}
      />
      <button type="submit" className="btn btn-light">
        Tambah Mata Kuliah
      </button>
    </form>
  );
};

class MatkulApp extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      listMatkul: matkulAwal,
      inputMatkul: "",
      showMessage: false,
    };
  }

  tambahMatkul = (matkulValue) => {
    this.setState(({ listMatkul }) => {
      const newItem = {
        value: matkulValue,
        index: listMatkul.length + 1,
      };
      return { listMatkul: [newItem].concat(listMatkul) };
    });
  };

  hapusMatkul = (itemIndex) =>
    this.setState(({ listMatkul }) => ({
      listMatkul: hapusMatkul(listMatkul, itemIndex),
      showMessage: true,
    }));

  onSubmit = (event) => {
    event.preventDefault();
    const { inputMatkul } = this.state;

    if (inputMatkul) {
      this.tambahMatkul(inputMatkul);
    }

    this.setState({ inputMatkul: "" });
  };

  oninputMatkulChange = (event) =>
    this.setState({ inputMatkul: event.target.value, showMessage: false });

  render() {
    const { inputMatkul, listMatkul } = this.state;

    return (
      <div id="main">
        <h1>Mata Kuliah</h1>
        {this.state.showMessage && <p>Matkul berhasil dihapus!</p>}
        <MatkulList listMatkul={listMatkul} hapusMatkul={this.hapusMatkul} />
        <MatkulForm
          tambahMatkul={this.tambahMatkul}
          onSubmit={this.onSubmit}
          inputMatkul={inputMatkul}
          oninputMatkulChange={this.oninputMatkulChange}
        />
      </div>
    );
  }
}

ReactDOM.render(<MatkulApp />, document.getElementById("root"));
